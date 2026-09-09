#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Update a Webhook<br/>
        /// Update a webhook's endpoint URL, its subscribed event types, or both. Omitted fields are left unchanged. `eventTypes` replaces the existing subscription rather than adding to it. The signing secret is unaffected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const webhook = await bb.webhooks.update("&lt;webhook-id&gt;", {<br/>
        ///   eventTypes: [<br/>
        ///     "functions.invocations.completed",<br/>
        ///     "functions.invocations.failed",<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(webhook);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.Webhook> WebhooksUpdateAsync(
            global::System.Guid id,

            global::Browserbase.WebhooksUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Webhook<br/>
        /// Update a webhook's endpoint URL, its subscribed event types, or both. Omitted fields are left unchanged. `eventTypes` replaces the existing subscription rather than adding to it. The signing secret is unaffected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const webhook = await bb.webhooks.update("&lt;webhook-id&gt;", {<br/>
        ///   eventTypes: [<br/>
        ///     "functions.invocations.completed",<br/>
        ///     "functions.invocations.failed",<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(webhook);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Webhook>> WebhooksUpdateAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.WebhooksUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Webhook<br/>
        /// Update a webhook's endpoint URL, its subscribed event types, or both. Omitted fields are left unchanged. `eventTypes` replaces the existing subscription rather than adding to it. The signing secret is unaffected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endpoint">
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Webhook> WebhooksUpdateAsync(
            global::System.Guid id,
            string? endpoint = default,
            global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? eventTypes = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}