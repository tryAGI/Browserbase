
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Current status of the run.<br/>
    /// - `PENDING` - agent will run soon<br/>
    /// - `RUNNING` - agent is currently running<br/>
    /// - `COMPLETED` - agent has finished running<br/>
    /// - `FAILED` - agent has failed the run<br/>
    /// - `STOPPED` - run was stopped by the user<br/>
    /// - `TIMED_OUT` - run exceeded maximum time
    /// </summary>
    public enum AgentRunStatus
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
    public static class AgentRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStatus value)
        {
            return value switch
            {
                AgentRunStatus.Completed => "COMPLETED",
                AgentRunStatus.Failed => "FAILED",
                AgentRunStatus.Pending => "PENDING",
                AgentRunStatus.Running => "RUNNING",
                AgentRunStatus.Stopped => "STOPPED",
                AgentRunStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AgentRunStatus.Completed,
                "FAILED" => AgentRunStatus.Failed,
                "PENDING" => AgentRunStatus.Pending,
                "RUNNING" => AgentRunStatus.Running,
                "STOPPED" => AgentRunStatus.Stopped,
                "TIMED_OUT" => AgentRunStatus.TimedOut,
                _ => null,
            };
        }
    }
}