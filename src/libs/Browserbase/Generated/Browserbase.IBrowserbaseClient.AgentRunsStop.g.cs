#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Stop a Run<br/>
        /// Request that an in-progress run stop. The run winds down and transitions to `STOPPED`. Stopping a run that has already finished returns a conflict.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.browserbase.com/v1/agents/runs/run-id/stop \<br/>
        ///   --header "X-BB-API-Key: $BROWSERBASE_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRun> AgentRunsStopAsync(
            string runId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop a Run<br/>
        /// Request that an in-progress run stop. The run winds down and transitions to `STOPPED`. Stopping a run that has already finished returns a conflict.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.browserbase.com/v1/agents/runs/run-id/stop \<br/>
        ///   --header "X-BB-API-Key: $BROWSERBASE_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentRun>> AgentRunsStopAsResponseAsync(
            string runId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}