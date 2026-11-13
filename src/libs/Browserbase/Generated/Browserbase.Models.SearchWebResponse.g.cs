
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebResponse
    {
        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The search query that was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The search provider that served the request. Can differ from the documented default when the project or the filters select another provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebResponseProviderJsonConverter))]
        public global::Browserbase.SearchWebResponseProvider? Provider { get; set; }

        /// <summary>
        /// The search mode that served the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebResponseModeJsonConverter))]
        public global::Browserbase.SearchWebResponseMode? Mode { get; set; }

        /// <summary>
        /// List of search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="query">
        /// The search query that was executed
        /// </param>
        /// <param name="results">
        /// List of search results
        /// </param>
        /// <param name="provider">
        /// The search provider that served the request. Can differ from the documented default when the project or the filters select another provider.
        /// </param>
        /// <param name="mode">
        /// The search mode that served the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebResponse(
            string requestId,
            string query,
            global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult> results,
            global::Browserbase.SearchWebResponseProvider? provider,
            global::Browserbase.SearchWebResponseMode? mode)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Provider = provider;
            this.Mode = mode;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebResponse" /> class.
        /// </summary>
        public SearchWebResponse()
        {
        }

    }
}