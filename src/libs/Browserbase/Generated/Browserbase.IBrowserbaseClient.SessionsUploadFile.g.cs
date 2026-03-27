#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create Session Uploads
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SessionsUploadFileResponse> SessionsUploadFileAsync(
            string id,

            global::Browserbase.SessionsUploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session Uploads
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SessionsUploadFileResponse> SessionsUploadFileAsync(
            string id,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}