#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get an Invocation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>> InvocationsGetAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}