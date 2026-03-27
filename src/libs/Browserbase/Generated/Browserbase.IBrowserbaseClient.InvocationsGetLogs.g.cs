#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Get Invocation Logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.InvocationsGetLogsResponse> InvocationsGetLogsAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}