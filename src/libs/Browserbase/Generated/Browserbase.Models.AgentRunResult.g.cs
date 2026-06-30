
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// The agent's structured result for the run. Only present when the run has finished and output is available. The result conforms to the provided [JSON Schema](https://json-schema.org/specification) when one is set.
    /// </summary>
    public sealed partial class AgentRunResult
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}