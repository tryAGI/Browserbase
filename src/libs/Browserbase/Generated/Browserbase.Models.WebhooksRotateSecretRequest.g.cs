
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksRotateSecretRequest
    {
        /// <summary>
        /// Expire the old secret at once instead of honouring it for 24 hours. Use when responding to a leak; deliveries signed with the old secret stop verifying immediately.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokeImmediately")]
        public bool? RevokeImmediately { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRotateSecretRequest" /> class.
        /// </summary>
        /// <param name="revokeImmediately">
        /// Expire the old secret at once instead of honouring it for 24 hours. Use when responding to a leak; deliveries signed with the old secret stop verifying immediately.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksRotateSecretRequest(
            bool? revokeImmediately)
        {
            this.RevokeImmediately = revokeImmediately;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRotateSecretRequest" /> class.
        /// </summary>
        public WebhooksRotateSecretRequest()
        {
        }

    }
}