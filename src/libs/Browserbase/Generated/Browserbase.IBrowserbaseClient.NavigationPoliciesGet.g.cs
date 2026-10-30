#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get a Navigation Policy<br/>
        /// Retrieve a single navigation policy by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const policy = await bb.navigationPolicies.retrieve("&lt;policy-id&gt;");<br/>
        /// console.log(policy.domainOverrides);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.NavigationPolicy> NavigationPoliciesGetAsync(
            global::System.Guid id,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Navigation Policy<br/>
        /// Retrieve a single navigation policy by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const policy = await bb.navigationPolicies.retrieve("&lt;policy-id&gt;");<br/>
        /// console.log(policy.domainOverrides);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.NavigationPolicy>> NavigationPoliciesGetAsResponseAsync(
            global::System.Guid id,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}