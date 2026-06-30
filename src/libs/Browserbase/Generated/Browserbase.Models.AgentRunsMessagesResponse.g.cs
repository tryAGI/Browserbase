
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunsMessagesResponse
    {
        /// <summary>
        /// The page of messages, in chronological order, with the oldest messages first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem> Data { get; set; }

        /// <summary>
        /// The `id` of the last message in `data`. Pass it back as `since` on the next request to continue paging, or to poll for new messages. `null` only when the run has no messages yet; in that case, omit `since` and retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextSince")]
        public string? NextSince { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The page of messages, in chronological order, with the oldest messages first.
        /// </param>
        /// <param name="nextSince">
        /// The `id` of the last message in `data`. Pass it back as `since` on the next request to continue paging, or to poll for new messages. `null` only when the run has no messages yet; in that case, omit `since` and retry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsMessagesResponse(
            global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem> data,
            string? nextSince)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextSince = nextSince;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponse" /> class.
        /// </summary>
        public AgentRunsMessagesResponse()
        {
        }

    }
}