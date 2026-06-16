#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class DownloadsListCommandApiCommand
{
    private static Option<string> SessionId { get; } = new(
        name: @"--session-id")
    {
        Description = @"Filter downloads by session ID (required).",
        Required = true,
    };

    private static Option<string?> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Filter by exact filename match.",
    };

    private static Option<string?> MimeType { get; } = new(
        name: @"--mime-type")
    {
        Description = @"Filter by MIME type.",
    };

    private static Option<double?> MinSize { get; } = new(
        name: @"--min-size")
    {
        Description = @"Minimum file size in bytes.",
    };

    private static Option<double?> MaxSize { get; } = new(
        name: @"--max-size")
    {
        Description = @"Maximum file size in bytes.",
    };

    private static Option<global::System.DateTime?> CreatedAfter { get; } = new(
        name: @"--created-after")
    {
        Description = @"Filter downloads created on or after this timestamp.",
    };

    private static Option<global::System.DateTime?> CreatedBefore { get; } = new(
        name: @"--created-before")
    {
        Description = @"Filter downloads created on or before this timestamp.",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of results to return.",
    };

    private static Option<double?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of results to skip for pagination.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.DownloadsListResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.DownloadsListResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"downloads-list", @"List Downloads
List all downloads for a session with optional filtering and pagination.");
                        command.Options.Add(SessionId);
                        command.Options.Add(Filename);
                        command.Options.Add(MimeType);
                        command.Options.Add(MinSize);
                        command.Options.Add(MaxSize);
                        command.Options.Add(CreatedAfter);
                        command.Options.Add(CreatedBefore);
                        command.Options.Add(Limit);
                        command.Options.Add(Offset);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var filename = parseResult.GetValue(Filename);
                        var mimeType = parseResult.GetValue(MimeType);
                        var minSize = parseResult.GetValue(MinSize);
                        var maxSize = parseResult.GetValue(MaxSize);
                        var createdAfter = parseResult.GetValue(CreatedAfter);
                        var createdBefore = parseResult.GetValue(CreatedBefore);
                        var limit = parseResult.GetValue(Limit);
                        var offset = parseResult.GetValue(Offset);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DownloadsListAsync(
                                    sessionId: sessionId,
                                    filename: filename,
                                    mimeType: mimeType,
                                    minSize: minSize,
                                    maxSize: maxSize,
                                    createdAfter: createdAfter,
                                    createdBefore: createdBefore,
                                    limit: limit,
                                    offset: offset,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Browserbase.SourceGenerationContext.Default,
                                        @"Downloads",
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