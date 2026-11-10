
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionsGetResponse2
    {
        /// <summary>
        /// Browserbase returns label IDs and current names only when includeLabels is true. An empty array means the session has no labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::Browserbase.SessionsGetResponseLabel>? Labels { get; set; }

        /// <summary>
        /// WebSocket URL to connect to the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectUrl")]
        public string? ConnectUrl { get; set; }

        /// <summary>
        /// HTTP URL to connect to the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seleniumRemoteUrl")]
        public string? SeleniumRemoteUrl { get; set; }

        /// <summary>
        /// Signing key to use when connecting to the Session via HTTP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingKey")]
        public string? SigningKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetResponse2" /> class.
        /// </summary>
        /// <param name="labels">
        /// Browserbase returns label IDs and current names only when includeLabels is true. An empty array means the session has no labels.
        /// </param>
        /// <param name="connectUrl">
        /// WebSocket URL to connect to the Session.
        /// </param>
        /// <param name="seleniumRemoteUrl">
        /// HTTP URL to connect to the Session.
        /// </param>
        /// <param name="signingKey">
        /// Signing key to use when connecting to the Session via HTTP.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsGetResponse2(
            global::System.Collections.Generic.IList<global::Browserbase.SessionsGetResponseLabel>? labels,
            string? connectUrl,
            string? seleniumRemoteUrl,
            string? signingKey)
        {
            this.Labels = labels;
            this.ConnectUrl = connectUrl;
            this.SeleniumRemoteUrl = seleniumRemoteUrl;
            this.SigningKey = signingKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetResponse2" /> class.
        /// </summary>
        public SessionsGetResponse2()
        {
        }

    }
}