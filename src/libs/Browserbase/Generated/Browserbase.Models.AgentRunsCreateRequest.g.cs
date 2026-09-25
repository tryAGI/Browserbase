
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRunsCreateRequest
    {
        /// <summary>
        /// Optionally run a specific [custom agent](/reference/api/create-an-agent) you've created by ID. The run will use the agent's `systemPrompt` and `resultSchema` unless overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// A natural language description of the task the agent should accomplish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, the agent will aim to return a `result` that conforms to this schema when the run completes. Overrides the referenced agent's default `resultSchema` for this run only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultSchema")]
        public object? ResultSchema { get; set; }

        /// <summary>
        /// Browser configuration for the agent's session. When omitted, runner defaults apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserSettings")]
        public global::Browserbase.AgentRunsCreateRequestBrowserSettings? BrowserSettings { get; set; }

        /// <summary>
        /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>? Variables { get; set; }

        /// <summary>
        /// Optional description of when the agent should pause and wait for input from your application (e.g. a verification code, an approval, or an answer from another system). When set, the agent is given a `pause` tool; calling it transitions the run to `PAUSED` (the agent's request is the trailing `pause` tool call in the run's messages) until it is resumed via the resume endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pauseWhen")]
        public string? PauseWhen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequest" /> class.
        /// </summary>
        /// <param name="task">
        /// A natural language description of the task the agent should accomplish.
        /// </param>
        /// <param name="agentId">
        /// Optionally run a specific [custom agent](/reference/api/create-an-agent) you've created by ID. The run will use the agent's `systemPrompt` and `resultSchema` unless overridden.
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
        /// <param name="pauseWhen">
        /// Optional description of when the agent should pause and wait for input from your application (e.g. a verification code, an approval, or an answer from another system). When set, the agent is given a `pause` tool; calling it transitions the run to `PAUSED` (the agent's request is the trailing `pause` tool call in the run's messages) until it is resumed via the resume endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsCreateRequest(
            string task,
            string? agentId,
            object? resultSchema,
            global::Browserbase.AgentRunsCreateRequestBrowserSettings? browserSettings,
            global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>? variables,
            string? pauseWhen)
        {
            this.AgentId = agentId;
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.ResultSchema = resultSchema;
            this.BrowserSettings = browserSettings;
            this.Variables = variables;
            this.PauseWhen = pauseWhen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequest" /> class.
        /// </summary>
        public AgentRunsCreateRequest()
        {
        }

    }
}