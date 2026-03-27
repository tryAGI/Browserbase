#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Create a Context
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.ContextsCreateResponse> ContextsCreateAsync(

            global::Browserbase.ContextsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Context
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.ContextsCreateResponse> ContextsCreateAsync(
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}