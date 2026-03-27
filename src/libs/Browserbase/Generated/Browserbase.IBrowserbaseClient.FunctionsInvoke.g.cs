#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Invoke a Function
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Invocation> FunctionsInvokeAsync(
            global::System.Guid id,

            global::Browserbase.FunctionsInvokeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invoke a Function
        /// </summary>
        /// <param name="id"></param>
        /// <param name="params">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        /// <param name="sessionCreateParams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Invocation> FunctionsInvokeAsync(
            global::System.Guid id,
            object? @params = default,
            global::Browserbase.FunctionsInvokeRequestSessionCreateParams? sessionCreateParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}