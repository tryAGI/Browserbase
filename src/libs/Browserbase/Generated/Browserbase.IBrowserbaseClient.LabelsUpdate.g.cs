#nullable enable

namespace Browserbase
{
    public partial interface IBrowserbaseClient
    {
        /// <summary>
        /// Update a Label<br/>
        /// Rename a label, preserving its ID, creation time, and session assignments.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Label> LabelsUpdateAsync(
            global::System.Guid labelId,

            global::Browserbase.LabelsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Label<br/>
        /// Rename a label, preserving its ID, creation time, and session assignments.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Label>> LabelsUpdateAsResponseAsync(
            global::System.Guid labelId,

            global::Browserbase.LabelsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Label<br/>
        /// Rename a label, preserving its ID, creation time, and session assignments.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="name">
        /// Label name. Browserbase trims surrounding Unicode whitespace and preserves display capitalization. The trimmed name must contain 1–128 Unicode characters and no NUL characters. Names are unique ignoring case within the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Browserbase.Label> LabelsUpdateAsync(
            global::System.Guid labelId,
            string name,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}