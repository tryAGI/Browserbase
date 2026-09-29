#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class SessionsGetReplayPageCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"Session ID",
    };

    private static Argument<string> PageId { get; } = new(
        name: @"page-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"sessions-get-replay-page", @"Get Replay Page
Returns an HLS VOD media playlist (.m3u8) for a specific page of a session replay.");
                        command.Arguments.Add(Id);
                        command.Arguments.Add(PageId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var pageId = parseResult.GetRequiredValue(PageId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SessionsGetReplayPageAsync(
                                    id: id,
                                    pageId: pageId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}