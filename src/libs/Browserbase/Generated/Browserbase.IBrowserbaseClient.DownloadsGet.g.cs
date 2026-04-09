#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get a Download<br/>
        /// Get download metadata (Accept: application/json) or file content (Accept: application/octet-stream).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.DownloadsGetResponse> DownloadsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}