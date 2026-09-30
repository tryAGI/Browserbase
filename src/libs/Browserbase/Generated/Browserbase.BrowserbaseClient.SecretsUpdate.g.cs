
#nullable enable

namespace Browserbase
{
    public partial class BrowserbaseClient
    {


        private static readonly global::Browserbase.EndPointSecurityRequirement s_SecretsUpdateSecurityRequirement0 =
            new global::Browserbase.EndPointSecurityRequirement
            {
                Authorizations = new global::Browserbase.EndPointAuthorizationRequirement[]
                {                    new global::Browserbase.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Browserbase.EndPointSecurityRequirement[] s_SecretsUpdateSecurityRequirements =
            new global::Browserbase.EndPointSecurityRequirement[]
            {                s_SecretsUpdateSecurityRequirement0,
            };
        partial void PrepareSecretsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            global::Browserbase.SecretsUpdateRequest request);
        partial void PrepareSecretsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            global::Browserbase.SecretsUpdateRequest request);
        partial void ProcessSecretsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a Secret<br/>
        /// Replace a secret's value. The name cannot be changed; to rename, create a new secret and delete the old one.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Browserbase.Secret> SecretsUpdateAsync(
            global::System.Guid id,

            global::Browserbase.SecretsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SecretsUpdateAsResponseAsync(
                id: id,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update a Secret<br/>
        /// Replace a secret's value. The name cannot be changed; to rename, create a new secret and delete the old one.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Browserbase.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Secret>> SecretsUpdateAsResponseAsync(
            global::System.Guid id,

            global::Browserbase.SecretsUpdateRequest request,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSecretsUpdateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::Browserbase.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SecretsUpdateSecurityRequirements,
                operationName: "SecretsUpdateAsync");

            using var __timeoutCancellationTokenSource = global::Browserbase.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Browserbase.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Browserbase.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Browserbase.PathBuilder(
                                path: $"/v1/secrets/{id}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Browserbase.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Browserbase.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSecretsUpdateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Browserbase.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Browserbase.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretsUpdate",
                                methodName: "SecretsUpdateAsync",
                                pathTemplate: "$\"/v1/secrets/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Browserbase.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Browserbase.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Browserbase.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretsUpdate",
                                methodName: "SecretsUpdateAsync",
                                pathTemplate: "$\"/v1/secrets/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Browserbase.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Browserbase.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Browserbase.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Browserbase.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Browserbase.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretsUpdate",
                                methodName: "SecretsUpdateAsync",
                                pathTemplate: "$\"/v1/secrets/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Browserbase.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSecretsUpdateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Browserbase.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Browserbase.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretsUpdate",
                                methodName: "SecretsUpdateAsync",
                                pathTemplate: "$\"/v1/secrets/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Browserbase.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Browserbase.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SecretsUpdate",
                                methodName: "SecretsUpdateAsync",
                                pathTemplate: "$\"/v1/secrets/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid request, or keypairId does not identify an active keypair in the project. If the keypair is no longer active, fetch GET /v1/secrets/keypair, seal the value again, and retry.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Browserbase.SecretsUpdateResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Browserbase.SecretsUpdateResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Browserbase.SecretsUpdateResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Browserbase.ApiException<global::Browserbase.SecretsUpdateResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The secret does not exist in the project.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Browserbase.SecretsUpdateResponse2? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Browserbase.SecretsUpdateResponse2.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Browserbase.SecretsUpdateResponse2.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Browserbase.ApiException<global::Browserbase.SecretsUpdateResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessSecretsUpdateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Browserbase.Secret.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Secret>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Browserbase.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Browserbase.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Browserbase.Secret.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Browserbase.AutoSDKHttpResponse<global::Browserbase.Secret>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Browserbase.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Browserbase.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update a Secret<br/>
        /// Replace a secret's value. The name cannot be changed; to rename, create a new secret and delete the old one.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sealedSecretValue">
        /// The new secret value encrypted with HPKE. To seal the secret value before sending, get the project's public key from GET /v1/secrets/keypair. Decode the publicKey using base64 into the raw 32-byte public key. Then, use HPKE Base mode (RFC 9180) with the following algorithm suite: DHKEM(X25519, HKDF-SHA256), HKDF-SHA256, and AES-256-GCM. Set both info and additional authenticated data (AAD) to an empty byte string. Then, create a new sender context using the public key and these settings, and encrypt the secret value as one message. Put the 32-byte encapsulated key before the ciphertext and keep the authentication tag at the end of the ciphertext. Encode the combined bytes with standard base64. Send the result as sealedSecretValue: base64(enc || ciphertext)
        /// </param>
        /// <param name="keypairId">
        /// The `id` returned by GET /v1/secrets/keypair, identifying the keypair whose public key encrypted the value. Recorded with the secret so decryption stays correct across keypair rotation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Browserbase.Secret> SecretsUpdateAsync(
            global::System.Guid id,
            string sealedSecretValue,
            string keypairId,
            global::Browserbase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Browserbase.SecretsUpdateRequest
            {
                SealedSecretValue = sealedSecretValue,
                KeypairId = keypairId,
            };

            return await SecretsUpdateAsync(
                id: id,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}