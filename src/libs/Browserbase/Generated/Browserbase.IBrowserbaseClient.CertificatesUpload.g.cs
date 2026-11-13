#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Upload a Certificate<br/>
        /// Upload a PEM file with one or more CA certificates (up to 100 MB). Pass the returned ID in `proxySettings.caCertificates` when creating a session so the browser trusts these certificates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Certificate> CertificatesUploadAsync(

            global::Browserbase.CertificatesUploadRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a Certificate<br/>
        /// Upload a PEM file with one or more CA certificates (up to 100 MB). Pass the returned ID in `proxySettings.caCertificates` when creating a session so the browser trusts these certificates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Certificate>> CertificatesUploadAsResponseAsync(

            global::Browserbase.CertificatesUploadRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a Certificate<br/>
        /// Upload a PEM file with one or more CA certificates (up to 100 MB). Pass the returned ID in `proxySettings.caCertificates` when creating a session so the browser trusts these certificates.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Certificate> CertificatesUploadAsync(
            byte[] file,
            string filename,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a Certificate<br/>
        /// Upload a PEM file with one or more CA certificates (up to 100 MB). Pass the returned ID in `proxySettings.caCertificates` when creating a session so the browser trusts these certificates.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Certificate> CertificatesUploadAsync(
            global::System.IO.Stream file,
            string filename,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a Certificate<br/>
        /// Upload a PEM file with one or more CA certificates (up to 100 MB). Pass the returned ID in `proxySettings.caCertificates` when creating a session so the browser trusts these certificates.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Certificate>> CertificatesUploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}