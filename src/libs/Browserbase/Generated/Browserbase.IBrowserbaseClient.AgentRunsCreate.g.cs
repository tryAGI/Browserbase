#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Run an Agent<br/>
        /// Run a browser agent to complete the `task` by using web search and browser tooling. Optionally pass `agentId` to run a [custom agent](/reference/api/create-an-agent) you've created.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRun> AgentRunsCreateAsync(

            global::Browserbase.AgentRunsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an Agent<br/>
        /// Run a browser agent to complete the `task` by using web search and browser tooling. Optionally pass `agentId` to run a [custom agent](/reference/api/create-an-agent) you've created.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AgentRun>> AgentRunsCreateAsResponseAsync(

            global::Browserbase.AgentRunsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an Agent<br/>
        /// Run a browser agent to complete the `task` by using web search and browser tooling. Optionally pass `agentId` to run a [custom agent](/reference/api/create-an-agent) you've created.
        /// </summary>
        /// <param name="agentId">
        /// Optionally run a specific [custom agent](/reference/api/create-an-agent) you've created by ID. The run will use the agent's `systemPrompt` and `resultSchema` unless overridden.
        /// </param>
        /// <param name="task">
        /// A natural language description of the task the agent should accomplish.
        /// </param>
        /// <param name="resultSchema">
        /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, the agent will aim to return a `result` that conforms to this schema when the run completes. Overrides the referenced agent's default `resultSchema` for this run only.
        /// </param>
        /// <param name="browserSettings">
        /// Browser configuration for the agent's session. When omitted, runner defaults apply.
        /// </param>
        /// <param name="variables">
        /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AgentRun> AgentRunsCreateAsync(
            string task,
            string? agentId = default,
            object? resultSchema = default,
            global::Browserbase.AgentRunsCreateRequestBrowserSettings? browserSettings = default,
            global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>? variables = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}