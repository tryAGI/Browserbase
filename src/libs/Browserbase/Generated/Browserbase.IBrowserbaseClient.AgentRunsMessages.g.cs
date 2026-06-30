#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Run Messages<br/>
        /// Returns a paginated list of messages produced by a run, in chronological order, with the oldest messages first.<br/>
        /// Messages conform to the [AI SDK UIMessage format](https://ai-sdk.dev/docs/reference/ai-sdk-core/ui-message).
        /// </summary>
        /// <param name="since"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRunsMessagesResponse> AgentRunsMessagesAsync(
            global::System.Guid runId,
            string? since = default,
            int? limit = default,
            bool? all = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Run Messages<br/>
        /// Returns a paginated list of messages produced by a run, in chronological order, with the oldest messages first.<br/>
        /// Messages conform to the [AI SDK UIMessage format](https://ai-sdk.dev/docs/reference/ai-sdk-core/ui-message).
        /// </summary>
        /// <param name="since"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentRunsMessagesResponse>> AgentRunsMessagesAsResponseAsync(
            global::System.Guid runId,
            string? since = default,
            int? limit = default,
            bool? all = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}