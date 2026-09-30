
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretsCreateRequest
    {
        /// <summary>
        /// The name to store the secret value under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// The secret value encrypted with HPKE. To seal the secret value before sending, get the project's public key from GET /v1/secrets/keypair. Decode the publicKey using base64 into the raw 32-byte public key. Then, use HPKE Base mode (RFC 9180) with the following algorithm suite: DHKEM(X25519, HKDF-SHA256), HKDF-SHA256, and AES-256-GCM. Set both info and additional authenticated data (AAD) to an empty byte string. Then, create a new sender context using the public key and these settings, and encrypt the secret value as one message. Put the 32-byte encapsulated key before the ciphertext and keep the authentication tag at the end of the ciphertext. Encode the combined bytes with standard base64. Send the result as sealedSecretValue: base64(enc || ciphertext)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sealedSecretValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SealedSecretValue { get; set; }

        /// <summary>
        /// The `id` returned by GET /v1/secrets/keypair, identifying the keypair whose public key encrypted the value. Recorded with the secret so decryption stays correct across keypair rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypairId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeypairId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsCreateRequest" /> class.
        /// </summary>
        /// <param name="secretKey">
        /// The name to store the secret value under.
        /// </param>
        /// <param name="sealedSecretValue">
        /// The secret value encrypted with HPKE. To seal the secret value before sending, get the project's public key from GET /v1/secrets/keypair. Decode the publicKey using base64 into the raw 32-byte public key. Then, use HPKE Base mode (RFC 9180) with the following algorithm suite: DHKEM(X25519, HKDF-SHA256), HKDF-SHA256, and AES-256-GCM. Set both info and additional authenticated data (AAD) to an empty byte string. Then, create a new sender context using the public key and these settings, and encrypt the secret value as one message. Put the 32-byte encapsulated key before the ciphertext and keep the authentication tag at the end of the ciphertext. Encode the combined bytes with standard base64. Send the result as sealedSecretValue: base64(enc || ciphertext)
        /// </param>
        /// <param name="keypairId">
        /// The `id` returned by GET /v1/secrets/keypair, identifying the keypair whose public key encrypted the value. Recorded with the secret so decryption stays correct across keypair rotation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretsCreateRequest(
            string secretKey,
            string sealedSecretValue,
            string keypairId)
        {
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.SealedSecretValue = sealedSecretValue ?? throw new global::System.ArgumentNullException(nameof(sealedSecretValue));
            this.KeypairId = keypairId ?? throw new global::System.ArgumentNullException(nameof(keypairId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretsCreateRequest" /> class.
        /// </summary>
        public SecretsCreateRequest()
        {
        }

    }
}