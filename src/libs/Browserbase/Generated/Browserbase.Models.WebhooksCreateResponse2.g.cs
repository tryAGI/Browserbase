
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksCreateResponse2
    {
        /// <summary>
        /// HMAC-SHA256 signing secret, prefixed `whsec_`. Shown once here; store it now. Use it to verify the signature on every delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksCreateResponse2" /> class.
        /// </summary>
        /// <param name="secret">
        /// HMAC-SHA256 signing secret, prefixed `whsec_`. Shown once here; store it now. Use it to verify the signature on every delivery.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksCreateResponse2(
            string secret)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksCreateResponse2" /> class.
        /// </summary>
        public WebhooksCreateResponse2()
        {
        }

    }
}