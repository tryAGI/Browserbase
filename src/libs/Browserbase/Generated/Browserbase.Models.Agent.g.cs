
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// A reusable agent. Referenced by `agentId` to apply a system prompt to every run that uses the agent.
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Unique identifier for the agent. Use this value as `agentId` when creating an agent run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Human-readable name for the agent. Used to identify the agent in the dashboard and API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// System prompt applied to every run that uses this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// [JSON Schema](https://json-schema.org/specification) that runs referencing this agent will aim to conform their `result` to. Can be overridden per run by passing `resultSchema` on the run request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultSchema")]
        public object? ResultSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier for the agent. Use this value as `agentId` when creating an agent run.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the agent. Used to identify the agent in the dashboard and API responses.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="systemPrompt">
        /// System prompt applied to every run that uses this agent.
        /// </param>
        /// <param name="resultSchema">
        /// [JSON Schema](https://json-schema.org/specification) that runs referencing this agent will aim to conform their `result` to. Can be overridden per run by passing `resultSchema` on the run request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            string agentId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? systemPrompt,
            object? resultSchema)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SystemPrompt = systemPrompt;
            this.ResultSchema = resultSchema;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }

    }
}