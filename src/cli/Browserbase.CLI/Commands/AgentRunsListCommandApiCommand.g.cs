#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class AgentRunsListCommandApiCommand
{
    private static Option<global::Browserbase.AgentRunsListStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Current status of the run.
- `PENDING` - agent will run soon
- `RUNNING` - agent is currently running
- `COMPLETED` - agent has finished running
- `FAILED` - agent has failed the run
- `STOPPED` - run was stopped by the user
- `TIMED_OUT` - run exceeded maximum time",
    };

    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Only return runs that reference this agent ID.",
    };

    private static Option<global::System.DateTime?> StartAt { get; } = new(
        name: @"--start-at")
    {
        Description = @"Only return runs created on or after this timestamp (inclusive). ISO 8601 / RFC 3339, e.g. 2026-01-19T00:00:00Z.",
    };

    private static Option<global::System.DateTime?> EndAt { get; } = new(
        name: @"--end-at")
    {
        Description = @"Only return runs created on or before this timestamp (inclusive). ISO 8601 / RFC 3339, e.g. 2026-01-20T00:00:00Z.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AgentRunsListResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AgentRunsListResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"agent-runs-list", @"List Runs
List runs across your account. Supports filtering by status, by the agent they reference, and by creation time.");
                        command.Options.Add(Status);
                        command.Options.Add(AgentId);
                        command.Options.Add(StartAt);
                        command.Options.Add(EndAt);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var status = parseResult.GetValue(Status);
                        var agentId = parseResult.GetValue(AgentId);
                        var startAt = parseResult.GetValue(StartAt);
                        var endAt = parseResult.GetValue(EndAt);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentRunsListAsync(
                                    status: status,
                                    agentId: agentId,
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