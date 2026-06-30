
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// One execution of an agent against a task. Created in `pending` and transitioned through `running` → `completed`/`failed` by the runner.
    /// </summary>
    public sealed partial class AgentRun
    {
        /// <summary>
        /// Unique identifier for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// The ID of the agent applied to this run, if any. Omitted for ad-hoc runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The original task description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Current status of the run.<br/>
        /// - `PENDING` - agent will run soon<br/>
        /// - `RUNNING` - agent is currently running<br/>
        /// - `COMPLETED` - agent has finished running<br/>
        /// - `FAILED` - agent has failed the run<br/>
        /// - `STOPPED` - run was stopped by the user<br/>
        /// - `TIMED_OUT` - run exceeded maximum time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AgentRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.AgentRunStatus Status { get; set; }

        /// <summary>
        /// The Browserbase session ID powering this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// External sandbox identifier assigned by the runner. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        public string? SandboxId { get; set; }

        /// <summary>
        /// Per-run [JSON Schema](https://json-schema.org/specification) override for the result shape. When unset, the agent's default `resultSchema` applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultSchema")]
        public object? ResultSchema { get; set; }

        /// <summary>
        /// The agent's structured result for the run. Only present when the run has finished and output is available. The result conforms to the provided [JSON Schema](https://json-schema.org/specification) when one is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public global::Browserbase.AgentRunCause? Cause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        /// <param name="runId">
        /// Unique identifier for the run.
        /// </param>
        /// <param name="task">
        /// The original task description.
        /// </param>
        /// <param name="status">
        /// Current status of the run.<br/>
        /// - `PENDING` - agent will run soon<br/>
        /// - `RUNNING` - agent is currently running<br/>
        /// - `COMPLETED` - agent has finished running<br/>
        /// - `FAILED` - agent has failed the run<br/>
        /// - `STOPPED` - run was stopped by the user<br/>
        /// - `TIMED_OUT` - run exceeded maximum time
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="agentId">
        /// The ID of the agent applied to this run, if any. Omitted for ad-hoc runs.
        /// </param>
        /// <param name="sessionId">
        /// The Browserbase session ID powering this run.
        /// </param>
        /// <param name="sandboxId">
        /// External sandbox identifier assigned by the runner. Optional.
        /// </param>
        /// <param name="resultSchema">
        /// Per-run [JSON Schema](https://json-schema.org/specification) override for the result shape. When unset, the agent's default `resultSchema` applies.
        /// </param>
        /// <param name="result">
        /// The agent's structured result for the run. Only present when the run has finished and output is available. The result conforms to the provided [JSON Schema](https://json-schema.org/specification) when one is set.
        /// </param>
        /// <param name="cause"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRun(
            string runId,
            string task,
            global::Browserbase.AgentRunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? agentId,
            string? sessionId,
            string? sandboxId,
            object? resultSchema,
            object? result,
            global::Browserbase.AgentRunCause? cause,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.AgentId = agentId;
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.Status = status;
            this.SessionId = sessionId;
            this.SandboxId = sandboxId;
            this.ResultSchema = resultSchema;
            this.Result = result;
            this.Cause = cause;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        public AgentRun()
        {
        }

    }
}