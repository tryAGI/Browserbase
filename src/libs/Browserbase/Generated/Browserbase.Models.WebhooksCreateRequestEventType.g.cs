
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksCreateRequestEventType
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
    public static class WebhooksCreateRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksCreateRequestEventType value)
        {
            return value switch
            {
                WebhooksCreateRequestEventType.FunctionsBuildsCompleted => "functions.builds.completed",
                WebhooksCreateRequestEventType.FunctionsBuildsFailed => "functions.builds.failed",
                WebhooksCreateRequestEventType.FunctionsBuildsRunning => "functions.builds.running",
                WebhooksCreateRequestEventType.FunctionsInvocationsCompleted => "functions.invocations.completed",
                WebhooksCreateRequestEventType.FunctionsInvocationsFailed => "functions.invocations.failed",
                WebhooksCreateRequestEventType.FunctionsInvocationsPending => "functions.invocations.pending",
                WebhooksCreateRequestEventType.FunctionsInvocationsRunning => "functions.invocations.running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksCreateRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "functions.builds.completed" => WebhooksCreateRequestEventType.FunctionsBuildsCompleted,
                "functions.builds.failed" => WebhooksCreateRequestEventType.FunctionsBuildsFailed,
                "functions.builds.running" => WebhooksCreateRequestEventType.FunctionsBuildsRunning,
                "functions.invocations.completed" => WebhooksCreateRequestEventType.FunctionsInvocationsCompleted,
                "functions.invocations.failed" => WebhooksCreateRequestEventType.FunctionsInvocationsFailed,
                "functions.invocations.pending" => WebhooksCreateRequestEventType.FunctionsInvocationsPending,
                "functions.invocations.running" => WebhooksCreateRequestEventType.FunctionsInvocationsRunning,
                _ => null,
            };
        }
    }
}