#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Delete a Download<br/>
        /// Delete a download file from storage and mark as deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}