
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Too many previous secrets are still inside their grace window. Wait for one to expire, or retry with `revokeImmediately`.
    /// </summary>
    public sealed partial class WebhooksRotateSecretResponse2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}