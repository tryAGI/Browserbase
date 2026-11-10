
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// A project-owned session label.
    /// </summary>
    public sealed partial class SessionsGetResponseLabel
    {
        /// <summary>
        /// Stable identifier of the label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name, unique ignoring case within the project.
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
        /// Initializes a new instance of the <see cref="SessionsGetResponseLabel" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the label.
        /// </param>
        /// <param name="name">
        /// Display name, unique ignoring case within the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsGetResponseLabel(
            global::System.Guid id,
            string name)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetResponseLabel" /> class.
        /// </summary>
        public SessionsGetResponseLabel()
        {
        }

    }
}