
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Browser configuration for the agent's session. When omitted, runner defaults apply.
    /// </summary>
    public sealed partial class AgentRunsCreateRequestBrowserSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Browserbase.AgentRunsCreateRequestBrowserSettingsContext? Context { get; set; }

        /// <summary>
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>))]
        public global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? Proxies { get; set; }

        /// <summary>
        /// Set true to enable Browserbase Verified for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequestBrowserSettings" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </param>
        /// <param name="verified">
        /// Set true to enable Browserbase Verified for the session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsCreateRequestBrowserSettings(
            global::Browserbase.AgentRunsCreateRequestBrowserSettingsContext? context,
            global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? proxies,
            bool? verified)
        {
            this.Context = context;
            this.Proxies = proxies;
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequestBrowserSettings" /> class.
        /// </summary>
        public AgentRunsCreateRequestBrowserSettings()
        {
        }

    }
}