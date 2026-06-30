
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.
    /// </summary>
    public sealed partial class AgentRunsCreateRequestVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}