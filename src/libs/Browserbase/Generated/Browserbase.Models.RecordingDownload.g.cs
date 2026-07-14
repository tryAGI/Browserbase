
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordingDownload
    {
        /// <summary>
        /// Recorded page (tab) within the session, e.g. "0", "1".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageId { get; set; }

        /// <summary>
        /// Per-page MP4 assembly state. `NOT_REQUESTED`: no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.RecordingDownloadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.RecordingDownloadStatus Status { get; set; }

        /// <summary>
        /// Short-lived signed CDN URL, re-minted each GET. Present only when COMPLETED on a standard (non-BYOS) project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// When the MP4 was created. Present only when COMPLETED on a standard (non-BYOS) project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingDownload" /> class.
        /// </summary>
        /// <param name="pageId">
        /// Recorded page (tab) within the session, e.g. "0", "1".
        /// </param>
        /// <param name="status">
        /// Per-page MP4 assembly state. `NOT_REQUESTED`: no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </param>
        /// <param name="downloadUrl">
        /// Short-lived signed CDN URL, re-minted each GET. Present only when COMPLETED on a standard (non-BYOS) project.
        /// </param>
        /// <param name="completedAt">
        /// When the MP4 was created. Present only when COMPLETED on a standard (non-BYOS) project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordingDownload(
            string pageId,
            global::Browserbase.RecordingDownloadStatus status,
            string? downloadUrl,
            global::System.DateTime? completedAt)
        {
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.Status = status;
            this.DownloadUrl = downloadUrl;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingDownload" /> class.
        /// </summary>
        public RecordingDownload()
        {
        }

    }
}