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
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="includeDomains">
        /// Only return results from these domains. Entries can be a hostname (example.com), a hostname with a path prefix (example.com/docs), or a wildcard subdomain (*.example.com). The `parallel` provider allows one list, not both, with at most 200 domains and no scheme, port, query string, or fragment.
        /// </param>
        /// <param name="excludeDomains">
        /// Never return results from these domains. Accepts the same entry formats as includeDomains. Not supported with the people category.
        /// </param>
        /// <param name="startPublishedDate">
        /// Only return results published after this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). The `parallel` provider rounds it up to a whole UTC day. Not supported with the company or people categories.
        /// </param>
        /// <param name="endPublishedDate">
        /// Only return results published before this date-time (RFC 3339, for example 2026-01-01T00:00:00Z). Only the `exa` provider supports this filter. Not supported with the company or people categories.
        /// </param>
        /// <param name="category">
        /// Focus the search on a category of content. Only the `exa` provider supports this filter.
        /// </param>
        /// <param name="userLocation">
        /// Two-letter ISO 3166-1 country code of the end user. Localizes ranking without restricting results to sources from that country. The `parallel` provider supports only [some countries](https://docs.browserbase.com/platform/search/overview#appendix-supported-countries).
        /// </param>
        /// <param name="moderation">
        /// Filter unsafe content from the results. Defaults to `false`. Only the `exa` provider supports `true`.
        /// </param>
        /// <param name="objective">
        /// The task intent and soft preferences for the search, in natural language. Adds context to query without replacing it.
        /// </param>
        /// <param name="maxAgeHours">
        /// Refetch a page when the cached copy is older than this many hours. Omit to use the provider default. A provider can return an older cached copy when a live fetch fails.
        /// </param>
        /// <param name="excerpts">
        /// Return the passages of each page most relevant to the query. Defaults to false.
        /// </param>
        /// <param name="provider">
        /// Search provider to serve this request. Defaults to `parallel`, which uses `advanced` mode unless `mode` is set. If you omit it and `parallel` can't apply one of your filters, `exa` serves the request at `exa` pricing. The response `provider` field shows which one served it.<br/>
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
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.DateTime? startPublishedDate = default,
            global::System.DateTime? endPublishedDate = default,
            global::Browserbase.SearchWebRequestCategory? category = default,
            string? userLocation = default,
            bool? moderation = default,
            string? objective = default,
            int? maxAgeHours = default,
            bool? excerpts = default,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? provider = default,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?, global::Browserbase.SearchWebRequestModeVariant3?, global::Browserbase.SearchWebRequestModeVariant4?>? mode = default,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}