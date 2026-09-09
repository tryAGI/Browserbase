
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// A delivery endpoint for a project. Browserbase POSTs a signed event to it whenever one of its subscribed event types occurs. The signing secret is returned only when it is created or rotated.
    /// </summary>
    public sealed partial class Webhook
    {
        /// <summary>
        /// Unique identifier for the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The project the webhook belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.WebhookEventType> EventTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the webhook.
        /// </param>
        /// <param name="projectId">
        /// The project the webhook belongs to.
        /// </param>
        /// <param name="endpoint">
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webhook(
            string id,
            string projectId,
            string endpoint,
            global::System.Collections.Generic.IList<global::Browserbase.WebhookEventType> eventTypes,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        public Webhook()
        {
        }

    }
}