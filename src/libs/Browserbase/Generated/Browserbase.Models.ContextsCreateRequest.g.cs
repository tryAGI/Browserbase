
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextsCreateRequest
    {
        /// <summary>
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Optional user-defined name for the Context. Leading and trailing whitespace is trimmed before storage. Names are unique within the project among active Contexts, compared case-insensitively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        /// <param name="name">
        /// Optional user-defined name for the Context. Leading and trailing whitespace is trimmed before storage. Names are unique within the project among active Contexts, compared case-insensitively.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextsCreateRequest(
            string? projectId,
            string? name)
        {
            this.ProjectId = projectId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateRequest" /> class.
        /// </summary>
        public ContextsCreateRequest()
        {
        }

    }
}