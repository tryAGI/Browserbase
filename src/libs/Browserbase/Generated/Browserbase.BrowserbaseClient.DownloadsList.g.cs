
#nullable enable

namespace Browserbase
{
    public partial class BrowserbaseClient
    {


        private static readonly global::Browserbase.EndPointSecurityRequirement s_DownloadsListSecurityRequirement0 =
            new global::Browserbase.EndPointSecurityRequirement
            {
                Authorizations = new global::Browserbase.EndPointAuthorizationRequirement[]
                {                    new global::Browserbase.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Browserbase.EndPointSecurityRequirement[] s_DownloadsListSecurityRequirements =
            new global::Browserbase.EndPointSecurityRequirement[]
            {                s_DownloadsListSecurityRequirement0,
            };
        partial void PrepareDownloadsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            ref string? filename,
            ref string? mimeType,
            ref double? minSize,
            ref double? maxSize,
            ref global::System.DateTime? createdAfter,
            ref global::System.DateTime? createdBefore,
            ref double? limit,
            ref double? offset);
        partial void PrepareDownloadsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            string? filename,
            string? mimeType,
            double? minSize,
            double? maxSize,
            global::System.DateTime? createdAfter,
            global::System.DateTime? createdBefore,
            double? limit,
            double? offset);
        partial void ProcessDownloadsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDownloadsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Downloads<br/>
        /// List all downloads for a session with optional filtering and pagination.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="filename"></param>
        /// <param name="mimeType"></param>
        /// <param name="minSize"></param>
        /// <param name="maxSize"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Browserbase.DownloadsListResponse> DownloadsListAsync(
            string sessionId,
            string? filename = default,
            string? mimeType = default,
            double? minSize = default,
            double? maxSize = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            double? limit = default,
            double? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDownloadsListArguments(
                httpClient: HttpClient,
                sessionId: ref sessionId,
                filename: ref filename,
                mimeType: ref mimeType,
                minSize: ref minSize,
                maxSize: ref maxSize,
                createdAfter: ref createdAfter,
                createdBefore: ref createdBefore,
                limit: ref limit,
                offset: ref offset);


            var __authorizations = global::Browserbase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DownloadsListSecurityRequirements,
                operationName: "DownloadsListAsync");

            var __pathBuilder = new global::Browserbase.PathBuilder(
                path: "/v1/downloads",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("sessionId", sessionId)
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("mimeType", mimeType)
                .AddOptionalParameter("minSize", minSize?.ToString())
                .AddOptionalParameter("maxSize", maxSize?.ToString())
                .AddOptionalParameter("createdAfter", createdAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("createdBefore", createdBefore?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDownloadsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sessionId: sessionId,
                filename: filename,
                mimeType: mimeType,
                minSize: minSize,
                maxSize: maxSize,
                createdAfter: createdAfter,
                createdBefore: createdBefore,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDownloadsListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessDownloadsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Browserbase.DownloadsListResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Browserbase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Browserbase.DownloadsListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Browserbase.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}