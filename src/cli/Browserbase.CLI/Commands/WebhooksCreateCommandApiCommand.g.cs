#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class WebhooksCreateCommandApiCommand
{
    private static Option<string> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType>> EventTypes { get; } = new(
        name: @"--event-types")
    {
        Description = @"Event types this webhook subscribes to. Unknown types are rejected.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"webhooks-create", @"Create a Webhook
Register an HTTPS endpoint to receive events for this project. The response includes the signing secret, which is shown only here and when the secret is rotated. Store it before discarding the response. An endpoint may only be registered once per project.");
                        command.Options.Add(Endpoint);
                        command.Options.Add(EventTypes);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var endpoint = parseResult.GetRequiredValue(Endpoint);
                        var eventTypes = parseResult.GetRequiredValue(EventTypes);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhooksCreateAsync(
                                    endpoint: endpoint,
                                    eventTypes: eventTypes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Browserbase.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}