#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class LabelsUpdateCommandApiCommand
{
    private static Argument<global::System.Guid> LabelId { get; } = new(
        name: @"label-id")
    {
        Description = @"The label's identifier.",
    };

    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Label name. Browserbase trims surrounding Unicode whitespace and preserves display capitalization. The trimmed name must contain 1–128 Unicode characters and no NUL characters. Names are unique ignoring case within the project.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.Label value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.Label value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"labels-update", @"Update a Label
Rename a label, preserving its ID, creation time, and session assignments.");
                        command.Arguments.Add(LabelId);
                        command.Options.Add(NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var labelId = parseResult.GetRequiredValue(LabelId);
                        var name = parseResult.GetRequiredValue(NameOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LabelsUpdateAsync(
                                    labelId: labelId,
                                    name: name,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Browserbase.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}