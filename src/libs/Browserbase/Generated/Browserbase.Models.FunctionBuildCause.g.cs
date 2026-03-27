
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionBuildCause
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.FunctionBuildCauseCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.FunctionBuildCauseCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildCause" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionBuildCause(
            global::Browserbase.FunctionBuildCauseCode code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildCause" /> class.
        /// </summary>
        public FunctionBuildCause()
        {
        }
    }
}