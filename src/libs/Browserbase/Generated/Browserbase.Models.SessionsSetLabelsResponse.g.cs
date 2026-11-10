
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionsSetLabelsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.Label> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSetLabelsResponse" /> class.
        /// </summary>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsSetLabelsResponse(
            global::System.Collections.Generic.IList<global::Browserbase.Label> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsSetLabelsResponse" /> class.
        /// </summary>
        public SessionsSetLabelsResponse()
        {
        }

    }
}