#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Agents<br/>
        /// List agents across your account. Supports filtering by creation time.
        /// </summary>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentsListResponse> AgentsListAsync(
            global::System.DateTime? startAt = default,
            global::System.DateTime? endAt = default,
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agents<br/>
        /// List agents across your account. Supports filtering by creation time.
        /// </summary>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentsListResponse>> AgentsListAsResponseAsync(
            global::System.DateTime? startAt = default,
            global::System.DateTime? endAt = default,
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}