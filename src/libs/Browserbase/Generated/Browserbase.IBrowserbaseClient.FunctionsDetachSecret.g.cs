#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Detach a Secret from a Function<br/>
        /// Detach a secret from a Function, taking effect on the Function's next invocation. Note: Detaching a secret that is not attached succeeds to support idempotency.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="secretId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsDetachSecretAsync(
            global::System.Guid id,
            global::System.Guid secretId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach a Secret from a Function<br/>
        /// Detach a secret from a Function, taking effect on the Function's next invocation. Note: Detaching a secret that is not attached succeeds to support idempotency.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="secretId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse> FunctionsDetachSecretAsResponseAsync(
            global::System.Guid id,
            global::System.Guid secretId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}