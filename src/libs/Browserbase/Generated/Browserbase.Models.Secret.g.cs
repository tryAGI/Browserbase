
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Secret
    {
        /// <summary>
        /// Unique identifier of the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name the secret value is stored under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Time at which the secret was created, in UTC, using RFC 3339 format, e.g. 2026-01-19T00:00:00.000Z.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Time at which the secret's value was last set, in UTC, using RFC 3339 format, e.g. 2026-01-20T00:00:00.000Z.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the secret.
        /// </param>
        /// <param name="secretKey">
        /// The name the secret value is stored under.
        /// </param>
        /// <param name="createdAt">
        /// Time at which the secret was created, in UTC, using RFC 3339 format, e.g. 2026-01-19T00:00:00.000Z.
        /// </param>
        /// <param name="updatedAt">
        /// Time at which the secret's value was last set, in UTC, using RFC 3339 format, e.g. 2026-01-20T00:00:00.000Z.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Secret(
            string id,
            string secretKey,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret" /> class.
        /// </summary>
        public Secret()
        {
        }

    }
}