
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRunsResumeRequest
    {
        /// <summary>
        /// Additional input for the agent: the reply to its request for input, which is the trailing `pause` tool call in the run's messages (e.g. an answer or an approval). Delivered to the agent as the result of that pause call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsResumeRequest" /> class.
        /// </summary>
        /// <param name="task">
        /// Additional input for the agent: the reply to its request for input, which is the trailing `pause` tool call in the run's messages (e.g. an answer or an approval). Delivered to the agent as the result of that pause call.
        /// </param>
        /// <param name="variables">
        /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsResumeRequest(
            string? task,
            global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>? variables)
        {
            this.Task = task;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsResumeRequest" /> class.
        /// </summary>
        public AgentRunsResumeRequest()
        {
        }

    }
}