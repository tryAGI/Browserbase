
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchCreateRequest
    {
        /// <summary>
        /// The URL to fetch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether to follow HTTP redirects<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowRedirects")]
        public bool? AllowRedirects { get; set; }

        /// <summary>
        /// Whether to bypass TLS certificate verification<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowInsecureSsl")]
        public bool? AllowInsecureSsl { get; set; }

        /// <summary>
        /// Whether to enable proxy support for the request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        public bool? Proxies { get; set; }

        /// <summary>
        /// Output format for the response content. `raw` (default) returns the response body unchanged; `json` returns structured data (requires `schema`); `markdown` returns the page as markdown.<br/>
        /// Default Value: raw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>))]
        public global::Browserbase.AnyOf<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>? Format { get; set; }

        /// <summary>
        /// JSON Schema describing the desired structure of the response. Only used when `format` is `json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch
        /// </param>
        /// <param name="allowRedirects">
        /// Whether to follow HTTP redirects<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowInsecureSsl">
        /// Whether to bypass TLS certificate verification<br/>
        /// Default Value: false
        /// </param>
        /// <param name="proxies">
        /// Whether to enable proxy support for the request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="format">
        /// Output format for the response content. `raw` (default) returns the response body unchanged; `json` returns structured data (requires `schema`); `markdown` returns the page as markdown.<br/>
        /// Default Value: raw
        /// </param>
        /// <param name="schema">
        /// JSON Schema describing the desired structure of the response. Only used when `format` is `json`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchCreateRequest(
            string url,
            bool? allowRedirects,
            bool? allowInsecureSsl,
            bool? proxies,
            global::Browserbase.AnyOf<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>? format,
            object? schema)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AllowRedirects = allowRedirects;
            this.AllowInsecureSsl = allowInsecureSsl;
            this.Proxies = proxies;
            this.Format = format;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateRequest" /> class.
        /// </summary>
        public FetchCreateRequest()
        {
        }

    }
}