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
        Description = @"Number of results to return",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> IncludeDomains { get; } = new(
        name: @"--include-domains")
    {
        Description = @"Only return results from these domains. Entries can be a hostname (example.com), a hostname with a path prefix (example.com/docs), or a wildcard subdomain (*.example.com). The `parallel` provider allows one list, not both, with at most 200 domains and no scheme, port, query string, or fragment.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
        name: @"--exclude-domains")
    {
        Description = @"Never return results from these domains. Accepts the same entry formats as includeDomains. Not supported with the people category.",
    };

    private static Option<global::System.DateTime?> StartPublishedDate { get; } = new(
        name: @"--start-published-date")
    {
        Description = @"Only return results published after this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). The `parallel` provider rounds it up to a whole UTC day. Not supported with the company or people categories.",
    };

    private static Option<global::System.DateTime?> EndPublishedDate { get; } = new(
        name: @"--end-published-date")
    {
        Description = @"Only return results published before this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). Only the `exa` provider supports this filter. Not supported with the company or people categories.",
    };

    private static Option<global::Browserbase.SearchWebRequestCategory?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Focus the search on a category of content. Only the `exa` provider supports this filter.",
    };

    private static Option<string?> UserLocation { get; } = new(
        name: @"--user-location")
    {
        Description = @"Two-letter ISO 3166-1 country code of the end user. Localizes ranking without restricting results to sources from that country. The `parallel` provider supports only [some countries](https://docs.browserbase.com/platform/search/overview#appendix-supported-countries).",
    };

    private static Option<bool?> Moderation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--moderation",
        description: @"Filter unsafe content from the results. Defaults to `false`. Only the `exa` provider supports `true`.");

    private static Option<string?> Objective { get; } = new(
        name: @"--objective")
    {
        Description = @"The task intent and soft preferences for the search, in natural language. Adds context to query without replacing it.",
    };

    private static Option<int?> MaxAgeHours { get; } = new(
        name: @"--max-age-hours")
    {
        Description = @"Refetch a page when the cached copy is older than this many hours. Omit to use the provider default. A provider can return an older cached copy when a live fetch fails.",
    };

    private static Option<bool?> Excerpts { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--excerpts",
        description: @"Return the passages of each page most relevant to the query. Defaults to false.");

    private static Option<global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set. If you omit it and `parallel` can't apply one of your filters, `exa` serves the request at `exa` pricing. The response `provider` field shows which one served it.",
    };

    private static Option<global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"The search mode used by the underlying provider. Defaults to `advanced` for `parallel` and `fast` for `exa`. See the [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes.",
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
                        command.Options.Add(IncludeDomains);
                        command.Options.Add(ExcludeDomains);
                        command.Options.Add(StartPublishedDate);
                        command.Options.Add(EndPublishedDate);
                        command.Options.Add(Category);
                        command.Options.Add(UserLocation);
                        command.Options.Add(Moderation);
                        command.Options.Add(Objective);
                        command.Options.Add(MaxAgeHours);
                        command.Options.Add(Excerpts);
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
                        var includeDomains = CliRuntime.WasSpecified(parseResult, IncludeDomains) ? parseResult.GetValue(IncludeDomains) : (__requestBase is { } __IncludeDomainsBaseValue ? __IncludeDomainsBaseValue.IncludeDomains : default);
                        var excludeDomains = CliRuntime.WasSpecified(parseResult, ExcludeDomains) ? parseResult.GetValue(ExcludeDomains) : (__requestBase is { } __ExcludeDomainsBaseValue ? __ExcludeDomainsBaseValue.ExcludeDomains : default);
                        var startPublishedDate = CliRuntime.WasSpecified(parseResult, StartPublishedDate) ? parseResult.GetValue(StartPublishedDate) : (__requestBase is { } __StartPublishedDateBaseValue ? __StartPublishedDateBaseValue.StartPublishedDate : default);
                        var endPublishedDate = CliRuntime.WasSpecified(parseResult, EndPublishedDate) ? parseResult.GetValue(EndPublishedDate) : (__requestBase is { } __EndPublishedDateBaseValue ? __EndPublishedDateBaseValue.EndPublishedDate : default);
                        var category = CliRuntime.WasSpecified(parseResult, Category) ? parseResult.GetValue(Category) : (__requestBase is { } __CategoryBaseValue ? __CategoryBaseValue.Category : default);
                        var userLocation = CliRuntime.WasSpecified(parseResult, UserLocation) ? parseResult.GetValue(UserLocation) : (__requestBase is { } __UserLocationBaseValue ? __UserLocationBaseValue.UserLocation : default);
                        var moderation = CliRuntime.WasSpecified(parseResult, Moderation) ? parseResult.GetValue(Moderation) : (__requestBase is { } __ModerationBaseValue ? __ModerationBaseValue.Moderation : default);
                        var objective = CliRuntime.WasSpecified(parseResult, Objective) ? parseResult.GetValue(Objective) : (__requestBase is { } __ObjectiveBaseValue ? __ObjectiveBaseValue.Objective : default);
                        var maxAgeHours = CliRuntime.WasSpecified(parseResult, MaxAgeHours) ? parseResult.GetValue(MaxAgeHours) : (__requestBase is { } __MaxAgeHoursBaseValue ? __MaxAgeHoursBaseValue.MaxAgeHours : default);
                        var excerpts = CliRuntime.WasSpecified(parseResult, Excerpts) ? parseResult.GetValue(Excerpts) : (__requestBase is { } __ExcerptsBaseValue ? __ExcerptsBaseValue.Excerpts : default);
                        var provider = CliRuntime.WasSpecified(parseResult, Provider) ? parseResult.GetValue(Provider) : (__requestBase is { } __ProviderBaseValue ? __ProviderBaseValue.Provider : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SearchWebAsync(
                                    query: query,
                                    numResults: numResults,
                                    includeDomains: includeDomains,
                                    excludeDomains: excludeDomains,
                                    startPublishedDate: startPublishedDate,
                                    endPublishedDate: endPublishedDate,
                                    category: category,
                                    userLocation: userLocation,
                                    moderation: moderation,
                                    objective: objective,
                                    maxAgeHours: maxAgeHours,
                                    excerpts: excerpts,
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