
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionBuild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.FunctionBuildRequest Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.FunctionBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.FunctionBuildStatus Status { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtFunctions")]
        public global::System.Collections.Generic.IList<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>? BuiltFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public global::Browserbase.FunctionBuildCause? Cause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuild" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="builtFunctions"></param>
        /// <param name="cause"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionBuild(
            global::System.Guid id,
            global::System.Guid projectId,
            global::Browserbase.FunctionBuildRequest request,
            global::Browserbase.FunctionBuildStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime startedAt,
            global::System.DateTime expiresAt,
            global::System.DateTime? endedAt,
            global::System.Collections.Generic.IList<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>? builtFunctions,
            global::Browserbase.FunctionBuildCause? cause)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.ExpiresAt = expiresAt;
            this.EndedAt = endedAt;
            this.BuiltFunctions = builtFunctions;
            this.Cause = cause;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuild" /> class.
        /// </summary>
        public FunctionBuild()
        {
        }
    }
}