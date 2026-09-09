#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Webhooks<br/>
        /// List the project's webhooks, newest first. Signing secrets are not included. Page by passing the previous response's `nextCursor` as `cursor`; a null `nextCursor` means there are no further pages.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const { data } = await bb.webhooks.list();<br/>
        /// console.log(data);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.WebhooksListResponse> WebhooksListAsync(
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Webhooks<br/>
        /// List the project's webhooks, newest first. Signing secrets are not included. Page by passing the previous response's `nextCursor` as `cursor`; a null `nextCursor` means there are no further pages.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const { data } = await bb.webhooks.list();<br/>
        /// console.log(data);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.WebhooksListResponse>> WebhooksListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}