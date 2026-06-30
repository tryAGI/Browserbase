
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCreateRequest
    {
        /// <summary>
        /// Human-readable name for the agent. Used to identify the agent in the dashboard and API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// System prompt that steers the agent's behavior on every run that uses this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, runs that reference this agent will aim to return a `result` that conforms to this schema when they complete. Can be overridden per run by passing `resultSchema` on the run request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultSchema")]
        public object? ResultSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCreateRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCreateRequest(
            string name,
            string? systemPrompt,
            object? resultSchema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SystemPrompt = systemPrompt;
            this.ResultSchema = resultSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCreateRequest" /> class.
        /// </summary>
        public AgentsCreateRequest()
        {
        }

    }
}