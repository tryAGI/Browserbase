#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Attach a Secret to a Function<br/>
        /// Attach a secret to a Function, taking effect on the Function's next invocation. Note: Attaching a secret that is already attached succeeds to support idempotency.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsAttachSecretAsync(
            global::System.Guid id,

            global::Browserbase.FunctionsAttachSecretRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a Secret to a Function<br/>
        /// Attach a secret to a Function, taking effect on the Function's next invocation. Note: Attaching a secret that is already attached succeeds to support idempotency.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse> FunctionsAttachSecretAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.FunctionsAttachSecretRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a Secret to a Function<br/>
        /// Attach a secret to a Function, taking effect on the Function's next invocation. Note: Attaching a secret that is already attached succeeds to support idempotency.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="secretId">
        /// The id of the project secret to attach (the `id` returned by POST /v1/secrets). Idempotent: re-attaching an already-attached secret succeeds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task FunctionsAttachSecretAsync(
            global::System.Guid id,
            global::System.Guid secretId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}