
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
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set.<br/>
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
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set.<br/>
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
            string? objective,
            int? maxAgeHours,
            bool? excerpts,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>? mode)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.NumResults = numResults;
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