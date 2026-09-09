
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookEventType
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
    public static class WebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType value)
        {
            return value switch
            {
                WebhookEventType.FunctionsBuildsCompleted => "functions.builds.completed",
                WebhookEventType.FunctionsBuildsFailed => "functions.builds.failed",
                WebhookEventType.FunctionsBuildsRunning => "functions.builds.running",
                WebhookEventType.FunctionsInvocationsCompleted => "functions.invocations.completed",
                WebhookEventType.FunctionsInvocationsFailed => "functions.invocations.failed",
                WebhookEventType.FunctionsInvocationsPending => "functions.invocations.pending",
                WebhookEventType.FunctionsInvocationsRunning => "functions.invocations.running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "functions.builds.completed" => WebhookEventType.FunctionsBuildsCompleted,
                "functions.builds.failed" => WebhookEventType.FunctionsBuildsFailed,
                "functions.builds.running" => WebhookEventType.FunctionsBuildsRunning,
                "functions.invocations.completed" => WebhookEventType.FunctionsInvocationsCompleted,
                "functions.invocations.failed" => WebhookEventType.FunctionsInvocationsFailed,
                "functions.invocations.pending" => WebhookEventType.FunctionsInvocationsPending,
                "functions.invocations.running" => WebhookEventType.FunctionsInvocationsRunning,
                _ => null,
            };
        }
    }
}