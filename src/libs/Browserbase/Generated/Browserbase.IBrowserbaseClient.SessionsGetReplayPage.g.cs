#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get Replay Page<br/>
        /// Returns an HLS VOD media playlist (.m3u8) for a specific page of a session replay.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SessionsGetReplayPageAsync(
            global::System.Guid id,
            string pageId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Replay Page<br/>
        /// Returns an HLS VOD media playlist (.m3u8) for a specific page of a session replay.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SessionsGetReplayPageAsStreamAsync(
            global::System.Guid id,
            string pageId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Replay Page<br/>
        /// Returns an HLS VOD media playlist (.m3u8) for a specific page of a session replay.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageId"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::System.IO.Stream>> SessionsGetReplayPageAsStreamAsResponseAsync(
            global::System.Guid id,
            string pageId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Replay Page<br/>
        /// Returns an HLS VOD media playlist (.m3u8) for a specific page of a session replay.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<byte[]>> SessionsGetReplayPageAsResponseAsync(
            global::System.Guid id,
            string pageId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}