#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Update a Navigation Policy<br/>
        /// Update a navigation policy. Omitted fields keep their values; a supplied list replaces the stored list rather than adding to it. The change applies to sessions that start afterwards; running sessions keep the policy they started with.
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
        /// const policy = await bb.navigationPolicies.update("&lt;policy-id&gt;", {<br/>
        ///   domainOverrides: [<br/>
        ///     { domain: "internal.example.com", decision: "block" },<br/>
        ///     { domain: "partner.example.net", decision: "allow" },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(policy.domainOverrides);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.NavigationPolicy> NavigationPoliciesUpdateAsync(
            global::System.Guid id,

            global::Browserbase.NavigationPoliciesUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Navigation Policy<br/>
        /// Update a navigation policy. Omitted fields keep their values; a supplied list replaces the stored list rather than adding to it. The change applies to sessions that start afterwards; running sessions keep the policy they started with.
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
        /// const policy = await bb.navigationPolicies.update("&lt;policy-id&gt;", {<br/>
        ///   domainOverrides: [<br/>
        ///     { domain: "internal.example.com", decision: "block" },<br/>
        ///     { domain: "partner.example.net", decision: "allow" },<br/>
        ///   ],<br/>
        /// });<br/>
        /// console.log(policy.domainOverrides);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.NavigationPolicy>> NavigationPoliciesUpdateAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.NavigationPoliciesUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Navigation Policy<br/>
        /// Update a navigation policy. Omitted fields keep their values; a supplied list replaces the stored list rather than adding to it. The change applies to sessions that start afterwards; running sessions keep the policy they started with.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Display name. A policy's id identifies it, not its name.
        /// </param>
        /// <param name="description">
        /// Free-form notes about the policy.
        /// </param>
        /// <param name="enabled">
        /// Whether the policy can be bound to new sessions. Running sessions keep the policy they started with. A disabled policy stays editable and can be re-enabled.
        /// </param>
        /// <param name="defaultDecision">
        /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
        /// </param>
        /// <param name="allowedCategories">
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </param>
        /// <param name="blockedCategories">
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </param>
        /// <param name="unknownDomainBehavior">
        /// Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.
        /// </param>
        /// <param name="domainOverrides">
        /// Per-host decisions that take precedence over category rules and the default. Each host may appear once.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.NavigationPolicy> NavigationPoliciesUpdateAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            bool? enabled = default,
            global::Browserbase.NavigationPoliciesUpdateRequestDefaultDecision? defaultDecision = default,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>? allowedCategories = default,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>? blockedCategories = default,
            global::Browserbase.NavigationPoliciesUpdateRequestUnknownDomainBehavior? unknownDomainBehavior = default,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>? domainOverrides = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}