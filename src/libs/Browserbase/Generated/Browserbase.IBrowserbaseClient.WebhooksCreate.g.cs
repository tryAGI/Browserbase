#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create a Webhook<br/>
        /// Register an HTTPS endpoint to receive events for this project. The response includes the signing secret, which is shown only here and when the secret is rotated. Store it before discarding the response. An endpoint may only be registered once per project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const webhook = await bb.webhooks.create({<br/>
        ///   endpoint: "https://example.com/browserbase/events",<br/>
        ///   eventTypes: ["functions.invocations.completed"],<br/>
        /// });<br/>
        /// console.log(webhook.secret);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>> WebhooksCreateAsync(

            global::Browserbase.WebhooksCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook<br/>
        /// Register an HTTPS endpoint to receive events for this project. The response includes the signing secret, which is shown only here and when the secret is rotated. Store it before discarding the response. An endpoint may only be registered once per project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const webhook = await bb.webhooks.create({<br/>
        ///   endpoint: "https://example.com/browserbase/events",<br/>
        ///   eventTypes: ["functions.invocations.completed"],<br/>
        /// });<br/>
        /// console.log(webhook.secret);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>>> WebhooksCreateAsResponseAsync(

            global::Browserbase.WebhooksCreateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook<br/>
        /// Register an HTTPS endpoint to receive events for this project. The response includes the signing secret, which is shown only here and when the secret is rotated. Store it before discarding the response. An endpoint may only be registered once per project.
        /// </summary>
        /// <param name="endpoint">
        /// HTTPS URL that event deliveries are POSTed to. Must be publicly reachable.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. Unknown types are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>> WebhooksCreateAsync(
            string endpoint,
            global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType> eventTypes,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}