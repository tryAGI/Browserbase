
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionsSetLabelsRequest
    {
        /// <summary>
        /// Complete replacement set of label names. Empty clears assignments; missing names create labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSetLabelsRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// Complete replacement set of label names. Empty clears assignments; missing names create labels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsSetLabelsRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSetLabelsRequest" /> class.
        /// </summary>
        public SessionsSetLabelsRequest()
        {
        }

    }
}