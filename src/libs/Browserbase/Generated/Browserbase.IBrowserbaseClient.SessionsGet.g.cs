#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get a Session
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>> SessionsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}