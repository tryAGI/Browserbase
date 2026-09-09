
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksUpdateRequest
    {
        /// <summary>
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksUpdateRequest" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksUpdateRequest(
            string? endpoint,
            global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? eventTypes)
        {
            this.Endpoint = endpoint;
            this.EventTypes = eventTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksUpdateRequest" /> class.
        /// </summary>
        public WebhooksUpdateRequest()
        {
        }

    }
}