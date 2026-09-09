
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// The new signing secret. Shown once; store it now.
    /// </summary>
    public sealed partial class WebhooksRotateSecretResponse
    {
        /// <summary>
        /// The new signing secret, prefixed `whsec_`.
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
        /// Initializes a new instance of the <see cref="WebhooksRotateSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The new signing secret, prefixed `whsec_`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksRotateSecretResponse(
            string secret)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRotateSecretResponse" /> class.
        /// </summary>
        public WebhooksRotateSecretResponse()
        {
        }

    }
}