
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionsAttachSecretRequest
    {
        /// <summary>
        /// The id of the project secret to attach (the `id` returned by POST /v1/secrets). Idempotent: re-attaching an already-attached secret succeeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsAttachSecretRequest" /> class.
        /// </summary>
        /// <param name="secretId">
        /// The id of the project secret to attach (the `id` returned by POST /v1/secrets). Idempotent: re-attaching an already-attached secret succeeds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionsAttachSecretRequest(
            global::System.Guid secretId)
        {
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsAttachSecretRequest" /> class.
        /// </summary>
        public FunctionsAttachSecretRequest()
        {
        }

    }
}