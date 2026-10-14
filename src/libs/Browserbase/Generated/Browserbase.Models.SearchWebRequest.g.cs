
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
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Search provider to serve this request. Omit to use the default provider for your project.<br/>
        /// Default Value: parallel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? Provider { get; set; }

        /// <summary>
        /// The search mode used by the underlying provider. [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes and defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?>? Mode { get; set; }

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
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="provider">
        /// Search provider to serve this request. Omit to use the default provider for your project.<br/>
        /// Default Value: parallel
        /// </param>
        /// <param name="mode">
        /// The search mode used by the underlying provider. [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes and defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequest(
            string query,
            int? numResults,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?>? mode)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.NumResults = numResults;
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