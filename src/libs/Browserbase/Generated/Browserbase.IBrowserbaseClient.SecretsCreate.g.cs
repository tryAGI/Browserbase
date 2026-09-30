#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Secret> SecretsCreateAsync(

            global::Browserbase.SecretsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Secret>> SecretsCreateAsResponseAsync(

            global::Browserbase.SecretsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Secret> SecretsCreateAsync(
            string secretKey,
            string sealedSecretValue,
            string keypairId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}