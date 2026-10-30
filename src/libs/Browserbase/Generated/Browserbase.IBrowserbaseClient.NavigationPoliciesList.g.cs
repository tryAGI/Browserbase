#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Navigation Policies<br/>
        /// List the project's navigation policies, ordered by name.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const { data: policies } = await bb.navigationPolicies.list();<br/>
        /// for (const policy of policies) {<br/>
        ///   console.log(policy.id, policy.name);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.NavigationPoliciesListResponse> NavigationPoliciesListAsync(
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Navigation Policies<br/>
        /// List the project's navigation policies, ordered by name.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        /// <remarks>
        /// import Browserbase from "@browserbasehq/sdk";<br/>
        /// const bb = new Browserbase({<br/>
        ///   apiKey: process.env.BROWSERBASE_API_KEY,<br/>
        /// });<br/>
        /// const { data: policies } = await bb.navigationPolicies.list();<br/>
        /// for (const policy of policies) {<br/>
        ///   console.log(policy.id, policy.name);<br/>
        /// }
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.NavigationPoliciesListResponse>> NavigationPoliciesListAsResponseAsync(
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}