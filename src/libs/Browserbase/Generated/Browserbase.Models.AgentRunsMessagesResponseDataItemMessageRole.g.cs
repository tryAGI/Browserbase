
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRunsMessagesResponseDataItemMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunsMessagesResponseDataItemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunsMessagesResponseDataItemMessageRole value)
        {
            return value switch
            {
                AgentRunsMessagesResponseDataItemMessageRole.Assistant => "assistant",
                AgentRunsMessagesResponseDataItemMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunsMessagesResponseDataItemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentRunsMessagesResponseDataItemMessageRole.Assistant,
                "tool" => AgentRunsMessagesResponseDataItemMessageRole.Tool,
                _ => null,
            };
        }
    }
}