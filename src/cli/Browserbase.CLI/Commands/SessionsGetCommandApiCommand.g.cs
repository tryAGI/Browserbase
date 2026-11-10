#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class SessionsGetCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<bool?> IncludeLabels { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-labels",
        description: @"Include the session's label IDs and current names.");

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"sessions-get", @"Get a Session");
                        command.Arguments.Add(Id);
                        command.Options.Add(IncludeLabels);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var includeLabels = parseResult.GetValue(IncludeLabels);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SessionsGetAsync(
                                    id: id,
                                    includeLabels: includeLabels,
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