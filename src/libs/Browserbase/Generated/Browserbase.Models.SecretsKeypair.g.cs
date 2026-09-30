
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretsKeypair
    {
        /// <summary>
        /// Identifier of the keypair the public key was minted from. Pass this back when creating a secret so the ciphertext records which keypair sealed it, which keeps decryption correct across keypair rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The project's HPKE public encryption key, base64-encoded. Encrypt secret values with this key before creating a secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsKeypair" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the keypair the public key was minted from. Pass this back when creating a secret so the ciphertext records which keypair sealed it, which keeps decryption correct across keypair rotation.
        /// </param>
        /// <param name="publicKey">
        /// The project's HPKE public encryption key, base64-encoded. Encrypt secret values with this key before creating a secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretsKeypair(
            string id,
            string publicKey)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsKeypair" /> class.
        /// </summary>
        public SecretsKeypair()
        {
        }

    }
}