
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadsListResponseDownload
    {
        /// <summary>
        /// Unique identifier for the download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Session ID this download belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The filename of the downloaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The MIME type of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// SHA256 checksum of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Checksum { get; set; }

        /// <summary>
        /// Timestamp when the file was downloaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadsListResponseDownload" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the download.
        /// </param>
        /// <param name="sessionId">
        /// The Session ID this download belongs to.
        /// </param>
        /// <param name="filename">
        /// The filename of the downloaded file.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.
        /// </param>
        /// <param name="size">
        /// File size in bytes.
        /// </param>
        /// <param name="checksum">
        /// SHA256 checksum of the file.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the file was downloaded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadsListResponseDownload(
            string id,
            string sessionId,
            string filename,
            string mimeType,
            double size,
            string checksum,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.Size = size;
            this.Checksum = checksum ?? throw new global::System.ArgumentNullException(nameof(checksum));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadsListResponseDownload" /> class.
        /// </summary>
        public DownloadsListResponseDownload()
        {
        }
    }
}