#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class SearchWebCommandApiCommand
{
    private static Option<string> Query { get; } = new(
        name: @"--query")
    {
        Description = @"The search query string",
        Required = true,
    };

    private static Option<int?> NumResults { get; } = new(
        name: @"--num-results")
    {
        Description = @"Number of results to return (1-25)",
    };

    private static Option<global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"Search provider to serve this request. Omit to use the default provider for your project.",
    };

    private static Option<global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?>?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"The search mode used by the underlying provider. [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes and defaults.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.SearchWebResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.SearchWebResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"search-web", @"Web Search
Perform a web search and return structured results.");
                        command.Options.Add(Query);
                        command.Options.Add(NumResults);
                        command.Options.Add(Provider);
                        command.Options.Add(Mode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.SearchWebRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var query = parseResult.GetRequiredValue(Query);
                        var numResults = CliRuntime.WasSpecified(parseResult, NumResults) ? parseResult.GetValue(NumResults) : (__requestBase is { } __NumResultsBaseValue ? __NumResultsBaseValue.NumResults : default);
                        var provider = CliRuntime.WasSpecified(parseResult, Provider) ? parseResult.GetValue(Provider) : (__requestBase is { } __ProviderBaseValue ? __ProviderBaseValue.Provider : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SearchWebAsync(
                                    query: query,
                                    numResults: numResults,
                                    provider: provider,
                                    mode: mode,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Browserbase.SourceGenerationContext.Default,
                                        @"Results",
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
        CustomizeCommand(ref command);
        return command;
    }
}