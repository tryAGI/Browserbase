#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class FetchCreateCommandApiCommand
{
    private static Argument<string> Url { get; } = new(
        name: @"url")
    {
        Description = @"The URL to fetch",
    };

    private static Option<bool?> AllowRedirects { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-redirects",
        description: @"Whether to follow HTTP redirects");

    private static Option<bool?> AllowInsecureSsl { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-insecure-ssl",
        description: @"Whether to bypass TLS certificate verification");

    private static Option<bool?> Proxies { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--proxies",
        description: @"Whether to enable proxy support for the request");

    private static Option<global::Browserbase.AnyOf<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Output format for the response content. `raw` (default) returns the response body unchanged; `json` returns structured data (requires `schema`); `markdown` returns the page as markdown.",
    };

    private static Option<object?> Schema { get; } = new(
        name: @"--schema")
    {
        Description = @"JSON Schema describing the desired structure of the response. Only used when `format` is `json`.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.FetchCreateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.FetchCreateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"fetch-create", @"Fetch a Page
Fetch a page and return its content, headers, and metadata.");
                        command.Arguments.Add(Url);
                        command.Options.Add(AllowRedirects);
                        command.Options.Add(AllowInsecureSsl);
                        command.Options.Add(Proxies);
                        command.Options.Add(Format);
                        command.Options.Add(Schema);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.FetchCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var url = parseResult.GetRequiredValue(Url);
                        var allowRedirects = CliRuntime.WasSpecified(parseResult, AllowRedirects) ? parseResult.GetValue(AllowRedirects) : (__requestBase is { } __AllowRedirectsBaseValue ? __AllowRedirectsBaseValue.AllowRedirects : default);
                        var allowInsecureSsl = CliRuntime.WasSpecified(parseResult, AllowInsecureSsl) ? parseResult.GetValue(AllowInsecureSsl) : (__requestBase is { } __AllowInsecureSslBaseValue ? __AllowInsecureSslBaseValue.AllowInsecureSsl : default);
                        var proxies = CliRuntime.WasSpecified(parseResult, Proxies) ? parseResult.GetValue(Proxies) : (__requestBase is { } __ProxiesBaseValue ? __ProxiesBaseValue.Proxies : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var schema = CliRuntime.WasSpecified(parseResult, Schema) ? parseResult.GetValue(Schema) : (__requestBase is { } __SchemaBaseValue ? __SchemaBaseValue.Schema : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.FetchCreateAsync(
                                    url: url,
                                    allowRedirects: allowRedirects,
                                    allowInsecureSsl: allowInsecureSsl,
                                    proxies: proxies,
                                    format: format,
                                    schema: schema,
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