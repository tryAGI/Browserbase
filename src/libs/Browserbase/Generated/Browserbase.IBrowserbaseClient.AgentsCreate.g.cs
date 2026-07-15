#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create an Agent<br/>
        /// Create a reusable agent. An agent defines a `systemPrompt` and `resultSchema` that guide its behavior for every run. Only `name` is required; an agent created with no `systemPrompt` behaves like an unconfigured run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const agent = await bb.agents.create({<br/>
        ///   name: "Job Finder",<br/>
        ///   systemPrompt: "Use official company career pages.",<br/>
        /// });<br/>
        /// console.log(agent);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.Agent> AgentsCreateAsync(

            global::Browserbase.AgentsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent<br/>
        /// Create a reusable agent. An agent defines a `systemPrompt` and `resultSchema` that guide its behavior for every run. Only `name` is required; an agent created with no `systemPrompt` behaves like an unconfigured run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const agent = await bb.agents.create({<br/>
        ///   name: "Job Finder",<br/>
        ///   systemPrompt: "Use official company career pages.",<br/>
        /// });<br/>
        /// console.log(agent);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Agent>> AgentsCreateAsResponseAsync(

            global::Browserbase.AgentsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agent<br/>
        /// Create a reusable agent. An agent defines a `systemPrompt` and `resultSchema` that guide its behavior for every run. Only `name` is required; an agent created with no `systemPrompt` behaves like an unconfigured run.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the agent. Used to identify the agent in the dashboard and API responses.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt that steers the agent's behavior on every run that uses this agent.
        /// </param>
        /// <param name="resultSchema">
        /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, runs that reference this agent will aim to return a `result` that conforms to this schema when they complete. Can be overridden per run by passing `resultSchema` on the run request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Agent> AgentsCreateAsync(
            string name,
            string? systemPrompt = default,
            object? resultSchema = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}