
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// [JSON Schema](https://json-schema.org/specification) that runs referencing this agent will aim to conform their `result` to. Can be overridden per run by passing `resultSchema` on the run request.
    /// </summary>
    public sealed partial class AgentResultSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}