#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Runs<br/>
        /// List runs across your account. Supports filtering by status, by the agent they reference, and by creation time.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="agentId"></param>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRunsListResponse> AgentRunsListAsync(
            global::Browserbase.AgentRunsListStatus? status = default,
            string? agentId = default,
            global::System.DateTime? startAt = default,
            global::System.DateTime? endAt = default,
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Runs<br/>
        /// List runs across your account. Supports filtering by status, by the agent they reference, and by creation time.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="agentId"></param>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentRunsListResponse>> AgentRunsListAsResponseAsync(
            global::Browserbase.AgentRunsListStatus? status = default,
            string? agentId = default,
            global::System.DateTime? startAt = default,
            global::System.DateTime? endAt = default,
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}