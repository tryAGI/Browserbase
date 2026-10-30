#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Web Search<br/>
        /// Perform a web search and return structured results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SearchWebResponse> SearchWebAsync(

            global::Browserbase.SearchWebRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search<br/>
        /// Perform a web search and return structured results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.SearchWebResponse>> SearchWebAsResponseAsync(

            global::Browserbase.SearchWebRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search<br/>
        /// Perform a web search and return structured results.
        /// </summary>
        /// <param name="query">
        /// The search query string
        /// </param>
        /// <param name="numResults">
        /// Number of results to return (1-25)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="provider">
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set.<br/>
        /// Default Value: parallel
        /// </param>
        /// <param name="mode">
        /// The search mode used by the underlying provider. Defaults to `advanced` for `parallel` and `fast` for `exa`. See the [Search docs](https://docs.browserbase.com/platform/search/overview) for the available modes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SearchWebResponse> SearchWebAsync(
            string query,
            int? numResults = default,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? provider = default,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>? mode = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}