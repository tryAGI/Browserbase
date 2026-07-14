
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsListRecordingDownloadsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload> Downloads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsListRecordingDownloadsResponse" /> class.
        /// </summary>
        /// <param name="downloads"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsListRecordingDownloadsResponse(
            global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload> downloads)
        {
            this.Downloads = downloads ?? throw new global::System.ArgumentNullException(nameof(downloads));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsListRecordingDownloadsResponse" /> class.
        /// </summary>
        public SessionsListRecordingDownloadsResponse()
        {
        }

    }
}