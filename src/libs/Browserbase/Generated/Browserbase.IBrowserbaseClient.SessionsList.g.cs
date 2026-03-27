#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// List Sessions
        /// </summary>
        /// <param name="status"></param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Browserbase.Session>> SessionsListAsync(
            global::Browserbase.SessionsListStatus? status = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}