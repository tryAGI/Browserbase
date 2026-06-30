#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class AgentRunsMessagesCommandApiCommand
{
    private static Argument<global::System.Guid> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The run ID.",
    };

    private static Option<string?> Since { get; } = new(
        name: @"--since")
    {
        Description = @"The `id` of the last message you've already received. The response will contain messages produced after that one, in chronological order. Omit on the first call. Pass the previous response's `nextSince` value to continue paging or to poll for new messages.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of messages to return.",
    };

    private static Option<bool?> All { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--all",
        description: @"Return every message after `since` in one response, ignoring `limit`.");

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AgentRunsMessagesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AgentRunsMessagesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"agent-runs-messages", @"List Run Messages
Returns a paginated list of messages produced by a run, in chronological order, with the oldest messages first.

Messages conform to the [AI SDK UIMessage format](https://ai-sdk.dev/docs/reference/ai-sdk-core/ui-message).");
                        command.Arguments.Add(RunId);
                        command.Options.Add(Since);
                        command.Options.Add(Limit);
                        command.Options.Add(All);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var since = parseResult.GetValue(Since);
                        var limit = parseResult.GetValue(Limit);
                        var all = parseResult.GetValue(All);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentRunsMessagesAsync(
                                    runId: runId,
                                    since: since,
                                    limit: limit,
                                    all: all,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Browserbase.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Browserbase.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}