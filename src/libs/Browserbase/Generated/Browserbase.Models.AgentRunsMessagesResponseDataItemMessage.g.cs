
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// An AI SDK response message (assistant or tool).
    /// </summary>
    public sealed partial class AgentRunsMessagesResponseDataItemMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AgentRunsMessagesResponseDataItemMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole Role { get; set; }

        /// <summary>
        /// Plain string (assistant text) or an array of typed parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponseDataItemMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// Plain string (assistant text) or an array of typed parts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsMessagesResponseDataItemMessage(
            global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole role,
            global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponseDataItemMessage" /> class.
        /// </summary>
        public AgentRunsMessagesResponseDataItemMessage()
        {
        }

    }
}