
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunsCreateRequestVariables2
    {
        /// <summary>
        /// The value the placeholder resolves to when the agent uses it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Optional hint to the agent describing what this variable represents and when to use it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequestVariables2" /> class.
        /// </summary>
        /// <param name="value">
        /// The value the placeholder resolves to when the agent uses it.
        /// </param>
        /// <param name="description">
        /// Optional hint to the agent describing what this variable represents and when to use it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsCreateRequestVariables2(
            string value,
            string? description)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsCreateRequestVariables2" /> class.
        /// </summary>
        public AgentRunsCreateRequestVariables2()
        {
        }

    }
}