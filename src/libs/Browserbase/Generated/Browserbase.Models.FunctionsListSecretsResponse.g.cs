
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// A page of secrets.
    /// </summary>
    public sealed partial class FunctionsListSecretsResponse
    {
        /// <summary>
        /// The page of matching secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.Secret> Data { get; set; }

        /// <summary>
        /// The maximum number of results returned in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Cursor for the next page. Pass it back as `cursor` on the next request to continue paging. null when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsListSecretsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The page of matching secrets.
        /// </param>
        /// <param name="limit">
        /// The maximum number of results returned in this page.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page. Pass it back as `cursor` on the next request to continue paging. null when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionsListSecretsResponse(
            global::System.Collections.Generic.IList<global::Browserbase.Secret> data,
            int limit,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Limit = limit;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsListSecretsResponse" /> class.
        /// </summary>
        public FunctionsListSecretsResponse()
        {
        }

    }
}