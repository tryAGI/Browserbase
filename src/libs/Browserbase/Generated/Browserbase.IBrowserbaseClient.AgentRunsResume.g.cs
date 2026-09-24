#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Resume a Run<br/>
        /// Resume a `PAUSED` run with additional input. The reply in `task` is delivered to the agent as the answer to its pause request (the trailing `pause` tool call in the run's messages), and `variables` merge over the run's original variables. Resuming a run that is not paused returns a conflict.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.browserbase.com/v1/agents/runs/run-id/resume \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header "X-BB-API-Key: $BROWSERBASE_API_KEY" \<br/>
        ///   --data '{<br/>
        ///     "task": "The code is %code%",<br/>
        ///     "variables": { "code": { "value": "123456" } }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRun> AgentRunsResumeAsync(
            string runId,

            global::Browserbase.AgentRunsResumeRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a Run<br/>
        /// Resume a `PAUSED` run with additional input. The reply in `task` is delivered to the agent as the answer to its pause request (the trailing `pause` tool call in the run's messages), and `variables` merge over the run's original variables. Resuming a run that is not paused returns a conflict.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.browserbase.com/v1/agents/runs/run-id/resume \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header "X-BB-API-Key: $BROWSERBASE_API_KEY" \<br/>
        ///   --data '{<br/>
        ///     "task": "The code is %code%",<br/>
        ///     "variables": { "code": { "value": "123456" } }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentRun>> AgentRunsResumeAsResponseAsync(
            string runId,

            global::Browserbase.AgentRunsResumeRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a Run<br/>
        /// Resume a `PAUSED` run with additional input. The reply in `task` is delivered to the agent as the answer to its pause request (the trailing `pause` tool call in the run's messages), and `variables` merge over the run's original variables. Resuming a run that is not paused returns a conflict.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="task">
        /// Additional input for the agent: the reply to its request for input, which is the trailing `pause` tool call in the run's messages (e.g. an answer or an approval). Delivered to the agent as the result of that pause call.
        /// </param>
        /// <param name="variables">
        /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRun> AgentRunsResumeAsync(
            string runId,
            string? task = default,
            global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>? variables = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}