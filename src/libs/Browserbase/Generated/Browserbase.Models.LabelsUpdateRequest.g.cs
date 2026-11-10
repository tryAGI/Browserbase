
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabelsUpdateRequest
    {
        /// <summary>
        /// Label name. Browserbase trims surrounding Unicode whitespace and preserves display capitalization. The trimmed name must contain 1–128 Unicode characters and no NUL characters. Names are unique ignoring case within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Label name. Browserbase trims surrounding Unicode whitespace and preserves display capitalization. The trimmed name must contain 1–128 Unicode characters and no NUL characters. Names are unique ignoring case within the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelsUpdateRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsUpdateRequest" /> class.
        /// </summary>
        public LabelsUpdateRequest()
        {
        }

    }
}