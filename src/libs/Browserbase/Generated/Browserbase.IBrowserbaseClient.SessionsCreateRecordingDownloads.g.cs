#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create Session Recording Downloads<br/>
        /// Requests one downloadable MP4 per recorded page of a session. Assembly runs asynchronously and every page returns as `PENDING`. Re-posting re-enqueues all pages and retries any that failed. Poll the GET endpoint for per-page status and, on standard (non-BYOS) projects, download URLs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SessionsCreateRecordingDownloadsResponse> SessionsCreateRecordingDownloadsAsync(
            global::System.Guid id,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session Recording Downloads<br/>
        /// Requests one downloadable MP4 per recorded page of a session. Assembly runs asynchronously and every page returns as `PENDING`. Re-posting re-enqueues all pages and retries any that failed. Poll the GET endpoint for per-page status and, on standard (non-BYOS) projects, download URLs.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.SessionsCreateRecordingDownloadsResponse>> SessionsCreateRecordingDownloadsAsResponseAsync(
            global::System.Guid id,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}