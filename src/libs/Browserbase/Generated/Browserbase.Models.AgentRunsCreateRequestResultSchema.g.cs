
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// An optional [JSON Schema](https://json-schema.org/specification) object. If provided, the agent will aim to return a `result` that conforms to this schema when the run completes. Overrides the referenced agent's default `resultSchema` for this run only.
    /// </summary>
    public sealed partial class AgentRunsCreateRequestResultSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}