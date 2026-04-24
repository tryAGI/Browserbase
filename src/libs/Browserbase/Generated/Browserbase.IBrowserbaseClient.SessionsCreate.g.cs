#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create a Session
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.browserbase.com/v1/sessions \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'X-BB-API-Key: &lt;api-key&gt;' \<br/>
        ///   --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>> SessionsCreateAsync(

            global::Browserbase.SessionsCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Session
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        /// <param name="extensionId">
        /// The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).
        /// </param>
        /// <param name="browserSettings"></param>
        /// <param name="timeout">
        /// Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.
        /// </param>
        /// <param name="keepAlive">
        /// Set to true to keep the session alive even after disconnections. Available on the Hobby Plan and above.
        /// </param>
        /// <param name="proxies">
        /// Proxy configuration. Can be true for default proxy, or an array of proxy configurations.
        /// </param>
        /// <param name="region">
        /// The region where the Session should run.<br/>
        /// Default Value: us-west-2
        /// </param>
        /// <param name="userMetadata">
        /// Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>> SessionsCreateAsync(
            string? projectId = default,
            string? extensionId = default,
            global::Browserbase.SessionsCreateRequestBrowserSettings? browserSettings = default,
            int? timeout = default,
            bool? keepAlive = default,
            global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? proxies = default,
            global::Browserbase.SessionsCreateRequestRegion? region = default,
            object? userMetadata = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}