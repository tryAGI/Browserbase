
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Per-page MP4 assembly state. `NOT_REQUESTED`: no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
    /// </summary>
    public enum RecordingDownloadStatus
    {
        /// <summary>
        /// no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </summary>
        Completed,
        /// <summary>
        /// no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </summary>
        Failed,
        /// <summary>
        /// no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </summary>
        NotRequested,
        /// <summary>
        /// no download has been requested for the session yet. `PENDING`: assembly is enqueued or in progress. `COMPLETED`: the MP4 is ready. `FAILED`: assembly failed; POST again to retry.
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordingDownloadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordingDownloadStatus value)
        {
            return value switch
            {
                RecordingDownloadStatus.Completed => "COMPLETED",
                RecordingDownloadStatus.Failed => "FAILED",
                RecordingDownloadStatus.NotRequested => "NOT_REQUESTED",
                RecordingDownloadStatus.Pending => "PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordingDownloadStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => RecordingDownloadStatus.Completed,
                "FAILED" => RecordingDownloadStatus.Failed,
                "NOT_REQUESTED" => RecordingDownloadStatus.NotRequested,
                "PENDING" => RecordingDownloadStatus.Pending,
                _ => null,
            };
        }
    }
}