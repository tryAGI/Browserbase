#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Update an Agent<br/>
        /// Update an existing agent. Only the fields provided in the body are modified; omitted fields are left unchanged.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Agent> AgentsUpdateAsync(
            string agentId,

            global::Browserbase.AgentsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent<br/>
        /// Update an existing agent. Only the fields provided in the body are modified; omitted fields are left unchanged.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Agent>> AgentsUpdateAsResponseAsync(
            string agentId,

            global::Browserbase.AgentsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Agent<br/>
        /// Update an existing agent. Only the fields provided in the body are modified; omitted fields are left unchanged.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// Human-readable name for the agent. Used to identify the agent in the dashboard and API responses.
        /// </param>
        /// <param name="systemPrompt">
        /// New system prompt that steers the agent's behavior on every run that uses this agent.
        /// </param>
        /// <param name="resultSchema">
        /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, runs that reference this agent will aim to return a `result` that conforms to this schema when they complete. Can be overridden per run by passing `resultSchema` on the run request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Agent> AgentsUpdateAsync(
            string agentId,
            string? name = default,
            string? systemPrompt = default,
            object? resultSchema = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}