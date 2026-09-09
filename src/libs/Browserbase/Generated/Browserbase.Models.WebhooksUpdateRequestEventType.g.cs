
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksUpdateRequestEventType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionsBuildsCompleted,
        /// <summary>
        ///
        /// </summary>
        FunctionsBuildsFailed,
        /// <summary>
        ///
        /// </summary>
        FunctionsBuildsRunning,
        /// <summary>
        ///
        /// </summary>
        FunctionsInvocationsCompleted,
        /// <summary>
        ///
        /// </summary>
        FunctionsInvocationsFailed,
        /// <summary>
        ///
        /// </summary>
        FunctionsInvocationsPending,
        /// <summary>
        ///
        /// </summary>
        FunctionsInvocationsRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksUpdateRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksUpdateRequestEventType value)
        {
            return value switch
            {
                WebhooksUpdateRequestEventType.FunctionsBuildsCompleted => "functions.builds.completed",
                WebhooksUpdateRequestEventType.FunctionsBuildsFailed => "functions.builds.failed",
                WebhooksUpdateRequestEventType.FunctionsBuildsRunning => "functions.builds.running",
                WebhooksUpdateRequestEventType.FunctionsInvocationsCompleted => "functions.invocations.completed",
                WebhooksUpdateRequestEventType.FunctionsInvocationsFailed => "functions.invocations.failed",
                WebhooksUpdateRequestEventType.FunctionsInvocationsPending => "functions.invocations.pending",
                WebhooksUpdateRequestEventType.FunctionsInvocationsRunning => "functions.invocations.running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksUpdateRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "functions.builds.completed" => WebhooksUpdateRequestEventType.FunctionsBuildsCompleted,
                "functions.builds.failed" => WebhooksUpdateRequestEventType.FunctionsBuildsFailed,
                "functions.builds.running" => WebhooksUpdateRequestEventType.FunctionsBuildsRunning,
                "functions.invocations.completed" => WebhooksUpdateRequestEventType.FunctionsInvocationsCompleted,
                "functions.invocations.failed" => WebhooksUpdateRequestEventType.FunctionsInvocationsFailed,
                "functions.invocations.pending" => WebhooksUpdateRequestEventType.FunctionsInvocationsPending,
                "functions.invocations.running" => WebhooksUpdateRequestEventType.FunctionsInvocationsRunning,
                _ => null,
            };
        }
    }
}