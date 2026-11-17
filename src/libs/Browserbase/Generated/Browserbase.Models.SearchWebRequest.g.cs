
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequest
    {
        /// <summary>
        /// The search query string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Only return results from these domains. Entries can be a hostname (example.com), a hostname with a path prefix (example.com/docs), or a wildcard subdomain (*.example.com). The `parallel` provider allows one list, not both, with at most 200 domains and no scheme, port, query string, or fragment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDomains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Never return results from these domains. Accepts the same entry formats as includeDomains. Not supported with the people category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeDomains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Only return results published after this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). The `parallel` provider rounds it up to a whole UTC day. Not supported with the company or people categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPublishedDate")]
        public global::System.DateTime? StartPublishedDate { get; set; }

        /// <summary>
        /// Only return results published before this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). Only the `exa` provider supports this filter. Not supported with the company or people categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPublishedDate")]
        public global::System.DateTime? EndPublishedDate { get; set; }

        /// <summary>
        /// Focus the search on a category of content. Only the `exa` provider supports this filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebRequestCategoryJsonConverter))]
        public global::Browserbase.SearchWebRequestCategory? Category { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 country code of the end user. Localizes ranking without restricting results to sources from that country. The `parallel` provider supports only [some countries](https://docs.browserbase.com/platform/search/overview#appendix-supported-countries).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLocation")]
        public string? UserLocation { get; set; }

        /// <summary>
        /// Filter unsafe content from the results. Defaults to `false`. Only the `exa` provider supports `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// The task intent and soft preferences for the search, in natural language. Adds context to query without replacing it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective")]
        public string? Objective { get; set; }

        /// <summary>
        /// Refetch a page when the cached copy is older than this many hours. Omit to use the provider default. A provider can return an older cached copy when a live fetch fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAgeHours")]
        public int? MaxAgeHours { get; set; }

        /// <summary>
        /// Return the passages of each page most relevant to the query. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerpts")]
        public bool? Excerpts { get; set; }

        /// <summary>
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set. If you omit it and `parallel` can't apply one of your filters, `exa` serves the request at `exa` pricing. The response `provider` field shows which one served it.<br/>
        /// Default Value: parallel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? Provider { get; set; }

        /// <summary>
        /// The search mode used by the underlying provider. Defaults to `advanced` for `parallel` and `fast` for `exa`. See the [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string
        /// </param>
        /// <param name="numResults">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="includeDomains">
        /// Only return results from these domains. Entries can be a hostname (example.com), a hostname with a path prefix (example.com/docs), or a wildcard subdomain (*.example.com). The `parallel` provider allows one list, not both, with at most 200 domains and no scheme, port, query string, or fragment.
        /// </param>
        /// <param name="excludeDomains">
        /// Never return results from these domains. Accepts the same entry formats as includeDomains. Not supported with the people category.
        /// </param>
        /// <param name="startPublishedDate">
        /// Only return results published after this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). The `parallel` provider rounds it up to a whole UTC day. Not supported with the company or people categories.
        /// </param>
        /// <param name="endPublishedDate">
        /// Only return results published before this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). Only the `exa` provider supports this filter. Not supported with the company or people categories.
        /// </param>
        /// <param name="category">
        /// Focus the search on a category of content. Only the `exa` provider supports this filter.
        /// </param>
        /// <param name="userLocation">
        /// Two-letter ISO 3166-1 country code of the end user. Localizes ranking without restricting results to sources from that country. The `parallel` provider supports only [some countries](https://docs.browserbase.com/platform/search/overview#appendix-supported-countries).
        /// </param>
        /// <param name="moderation">
        /// Filter unsafe content from the results. Defaults to `false`. Only the `exa` provider supports `true`.
        /// </param>
        /// <param name="objective">
        /// The task intent and soft preferences for the search, in natural language. Adds context to query without replacing it.
        /// </param>
        /// <param name="maxAgeHours">
        /// Refetch a page when the cached copy is older than this many hours. Omit to use the provider default. A provider can return an older cached copy when a live fetch fails.
        /// </param>
        /// <param name="excerpts">
        /// Return the passages of each page most relevant to the query. Defaults to false.
        /// </param>
        /// <param name="provider">
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set. If you omit it and `parallel` can't apply one of your filters, `exa` serves the request at `exa` pricing. The response `provider` field shows which one served it.<br/>
        /// Default Value: parallel
        /// </param>
        /// <param name="mode">
        /// The search mode used by the underlying provider. Defaults to `advanced` for `parallel` and `fast` for `exa`. See the [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequest(
            string query,
            int? numResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            global::Browserbase.SearchWebRequestCategory? category,
            string? userLocation,
            bool? moderation,
            string? objective,
            int? maxAgeHours,
            bool? excerpts,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>? mode)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.NumResults = numResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.Category = category;
            this.UserLocation = userLocation;
            this.Moderation = moderation;
            this.Objective = objective;
            this.MaxAgeHours = maxAgeHours;
            this.Excerpts = excerpts;
            this.Provider = provider;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequest" /> class.
        /// </summary>
        public SearchWebRequest()
        {
        }

    }
}