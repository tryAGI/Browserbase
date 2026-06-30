#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class AgentsListCommandApiCommand
{
    private static Option<global::System.DateTime?> StartAt { get; } = new(
        name: @"--start-at")
    {
        Description = @"Only return agents created on or after this timestamp (inclusive). ISO 8601 / RFC 3339, e.g. 2026-01-19T00:00:00Z.",
    };

    private static Option<global::System.DateTime?> EndAt { get; } = new(
        name: @"--end-at")
    {
        Description = @"Only return agents created on or before this timestamp (inclusive). ISO 8601 / RFC 3339, e.g. 2026-01-20T00:00:00Z.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of results to return.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Pagination cursor. Pass the nextCursor from the previous response to fetch the next page. Omit to start from the first page.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AgentsListResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AgentsListResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"agents-list", @"List Agents
List agents across your account. Supports filtering by creation time.");
                        command.Options.Add(StartAt);
                        command.Options.Add(EndAt);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var startAt = parseResult.GetValue(StartAt);
                        var endAt = parseResult.GetValue(EndAt);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentsListAsync(
                                    startAt: startAt,
                                    endAt: endAt,
                                    limit: limit,
                                    cursor: cursor,
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