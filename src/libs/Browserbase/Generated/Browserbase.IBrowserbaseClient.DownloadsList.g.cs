#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Downloads<br/>
        /// List all downloads for a session with optional filtering and pagination.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="filename"></param>
        /// <param name="mimeType"></param>
        /// <param name="minSize"></param>
        /// <param name="maxSize"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.DownloadsListResponse> DownloadsListAsync(
            string sessionId,
            string? filename = default,
            string? mimeType = default,
            double? minSize = default,
            double? maxSize = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            double? limit = default,
            double? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}