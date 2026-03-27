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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SearchWebResponse> SearchWebAsync(

            global::Browserbase.SearchWebRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.SearchWebResponse> SearchWebAsync(
            string query,
            int? numResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}