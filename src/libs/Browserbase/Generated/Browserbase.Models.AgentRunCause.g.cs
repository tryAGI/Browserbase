
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunCause
    {
        /// <summary>
        /// Structured failure code (e.g., RUNNER_HEARTBEAT_LOST).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable failure detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunCause" /> class.
        /// </summary>
        /// <param name="code">
        /// Structured failure code (e.g., RUNNER_HEARTBEAT_LOST).
        /// </param>
        /// <param name="message">
        /// Human-readable failure detail.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunCause(
            string code,
            string? message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunCause" /> class.
        /// </summary>
        public AgentRunCause()
        {
        }

    }
}