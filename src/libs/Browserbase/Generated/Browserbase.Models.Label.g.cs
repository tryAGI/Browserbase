
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// A project-owned session label.
    /// </summary>
    public sealed partial class Label
    {
        /// <summary>
        /// Stable identifier of the label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The project that owns the label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Display name, unique ignoring case within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// UTC timestamp when the label was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// UTC timestamp when the label was last renamed.
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
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the label.
        /// </param>
        /// <param name="projectId">
        /// The project that owns the label.
        /// </param>
        /// <param name="name">
        /// Display name, unique ignoring case within the project.
        /// </param>
        /// <param name="createdAt">
        /// UTC timestamp when the label was created.
        /// </param>
        /// <param name="updatedAt">
        /// UTC timestamp when the label was last renamed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Label(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
        }

    }
}