#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Rotate a Webhook signing secret<br/>
        /// Issue a new signing secret for a webhook. By default the previous secret keeps verifying for 24 hours so a receiver can be updated without dropping deliveries; pass `revokeImmediately` to end that window at once. The new secret is returned only here.
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
        /// const { secret } = await bb.webhooks.rotateSecret("&lt;webhook-id&gt;");<br/>
        /// console.log(secret);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.WebhooksRotateSecretResponse> WebhooksRotateSecretAsync(
            global::System.Guid id,

            global::Browserbase.WebhooksRotateSecretRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a Webhook signing secret<br/>
        /// Issue a new signing secret for a webhook. By default the previous secret keeps verifying for 24 hours so a receiver can be updated without dropping deliveries; pass `revokeImmediately` to end that window at once. The new secret is returned only here.
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
        /// const { secret } = await bb.webhooks.rotateSecret("&lt;webhook-id&gt;");<br/>
        /// console.log(secret);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.WebhooksRotateSecretResponse>> WebhooksRotateSecretAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.WebhooksRotateSecretRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate a Webhook signing secret<br/>
        /// Issue a new signing secret for a webhook. By default the previous secret keeps verifying for 24 hours so a receiver can be updated without dropping deliveries; pass `revokeImmediately` to end that window at once. The new secret is returned only here.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="revokeImmediately">
        /// Expire the old secret at once instead of honouring it for 24 hours. Use when responding to a leak; deliveries signed with the old secret stop verifying immediately.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.WebhooksRotateSecretResponse> WebhooksRotateSecretAsync(
            global::System.Guid id,
            bool? revokeImmediately = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}