
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRunsListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunsListStatus value)
        {
            return value switch
            {
                AgentRunsListStatus.Completed => "COMPLETED",
                AgentRunsListStatus.Failed => "FAILED",
                AgentRunsListStatus.Pending => "PENDING",
                AgentRunsListStatus.Running => "RUNNING",
                AgentRunsListStatus.Stopped => "STOPPED",
                AgentRunsListStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AgentRunsListStatus.Completed,
                "FAILED" => AgentRunsListStatus.Failed,
                "PENDING" => AgentRunsListStatus.Pending,
                "RUNNING" => AgentRunsListStatus.Running,
                "STOPPED" => AgentRunsListStatus.Stopped,
                "TIMED_OUT" => AgentRunsListStatus.TimedOut,
                _ => null,
            };
        }
    }
}