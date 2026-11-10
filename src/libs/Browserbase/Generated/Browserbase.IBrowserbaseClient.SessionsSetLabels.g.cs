#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Set Session Labels<br/>
        /// Atomically replace a session's labels. Returns the response after the assignment commits.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SessionsSetLabelsResponse> SessionsSetLabelsAsync(
            global::System.Guid id,

            global::Browserbase.SessionsSetLabelsRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Session Labels<br/>
        /// Atomically replace a session's labels. Returns the response after the assignment commits.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.SessionsSetLabelsResponse>> SessionsSetLabelsAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.SessionsSetLabelsRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Session Labels<br/>
        /// Atomically replace a session's labels. Returns the response after the assignment commits.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="labels">
        /// Complete replacement set of label names. Empty clears assignments; missing names create labels.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SessionsSetLabelsResponse> SessionsSetLabelsAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> labels,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}