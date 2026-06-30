
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunsMessagesResponseDataItemMessageContentVariant2Item
    {
        /// <summary>
        /// text | reasoning | file | tool-call | tool-result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponseDataItemMessageContentVariant2Item" /> class.
        /// </summary>
        /// <param name="type">
        /// text | reasoning | file | tool-call | tool-result
        /// </param>
        /// <param name="text"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolName"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="mediaType"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunsMessagesResponseDataItemMessageContentVariant2Item(
            string type,
            string? text,
            string? toolCallId,
            string? toolName,
            object? input,
            object? output,
            string? mediaType,
            string? data)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text;
            this.ToolCallId = toolCallId;
            this.ToolName = toolName;
            this.Input = input;
            this.Output = output;
            this.MediaType = mediaType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunsMessagesResponseDataItemMessageContentVariant2Item" /> class.
        /// </summary>
        public AgentRunsMessagesResponseDataItemMessageContentVariant2Item()
        {
        }

    }
}