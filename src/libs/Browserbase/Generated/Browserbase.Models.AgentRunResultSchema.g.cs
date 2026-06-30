
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Per-run [JSON Schema](https://json-schema.org/specification) override for the result shape. When unset, the agent's default `resultSchema` applies.
    /// </summary>
    public sealed partial class AgentRunResultSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}