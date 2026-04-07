
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParams
    {
        /// <summary>
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensionId")]
        public string? ExtensionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserSettings")]
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? BrowserSettings { get; set; }

        /// <summary>
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>))]
        public global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? Proxies { get; set; }

        /// <summary>
        /// [NOT IN DOCS] Supplementary proxy settings. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxySettings")]
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings? ProxySettings { get; set; }

        /// <summary>
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/platform/browser/core-features/session-metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userMetadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParams" /> class.
        /// </summary>
        /// <param name="extensionId">
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </param>
        /// <param name="browserSettings"></param>
        /// <param name="timeout">
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </param>
        /// <param name="proxySettings">
        /// [NOT IN DOCS] Supplementary proxy settings. Optional.
        /// </param>
        /// <param name="userMetadata">
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/platform/browser/core-features/session-metadata).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionsInvokeRequestSessionCreateParams(
            string? extensionId,
            global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? browserSettings,
            int? timeout,
            global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? proxies,
            global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings? proxySettings,
            object? userMetadata)
        {
            this.ExtensionId = extensionId;
            this.BrowserSettings = browserSettings;
            this.Timeout = timeout;
            this.Proxies = proxies;
            this.ProxySettings = proxySettings;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParams" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParams()
        {
        }
    }
}