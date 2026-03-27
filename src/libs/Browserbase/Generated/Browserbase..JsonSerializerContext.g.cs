
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Browserbase.JsonConverters.BrowserbaseProxyConfigTypeJsonConverter),

            typeof(global::Browserbase.JsonConverters.BrowserbaseProxyConfigTypeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.ExternalProxyConfigTypeJsonConverter),

            typeof(global::Browserbase.JsonConverters.ExternalProxyConfigTypeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionBuildStatusJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionBuildStatusNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionBuildCauseCodeJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionBuildCauseCodeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.InvocationStatusJsonConverter),

            typeof(global::Browserbase.JsonConverters.InvocationStatusNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.NoneProxyConfigTypeJsonConverter),

            typeof(global::Browserbase.JsonConverters.NoneProxyConfigTypeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionStatusJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionStatusNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionRegionJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionRegionNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOsNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionJsonConverter),

            typeof(global::Browserbase.JsonConverters.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsCreateRequestBrowserSettingsOsJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsCreateRequestBrowserSettingsOsNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsCreateRequestRegionJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsCreateRequestRegionNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsUpdateRequestStatusJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsUpdateRequestStatusNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsListStatusJsonConverter),

            typeof(global::Browserbase.JsonConverters.SessionsListStatusNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.InvocationsGetResponseCauseCodeJsonConverter),

            typeof(global::Browserbase.JsonConverters.InvocationsGetResponseCauseCodeNullableJsonConverter),

            typeof(global::Browserbase.JsonConverters.AllOfJsonConverter<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>),

            typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>),

            typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>),

            typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>),

            typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>),

            typeof(global::Browserbase.JsonConverters.AllOfJsonConverter<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>),

            typeof(global::Browserbase.JsonConverters.AllOfJsonConverter<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>),

            typeof(global::Browserbase.JsonConverters.AllOfJsonConverter<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>),

            typeof(global::Browserbase.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.BrowserbaseProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.BrowserbaseProxyConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.BrowserbaseProxyConfigGeolocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Extension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ExternalProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ExternalProxyConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildBuiltFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildCause))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildCauseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Invocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.NoneProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.NoneProxyConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ProjectUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionLiveUrls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.SessionLiveUrlsPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionLiveUrlsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionLogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionRecording))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ContextsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ExtensionsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SearchWebRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequestBrowserSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequestBrowserSettingsContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequestBrowserSettingsViewport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequestBrowserSettingsOs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateRequestRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsUpdateRequestStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsListStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ContextsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.ContextsUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FetchCreateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.FunctionBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionBuildsGetLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.FunctionBuildLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationsGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationsGetResponseCause))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationsGetResponseCauseCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.InvocationsGetLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.InvocationLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionVersionsListInvocationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.Invocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.FunctionsListVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.FunctionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SearchWebResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SearchWebResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.SessionLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Browserbase.SessionRecording>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.SessionsUploadFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.SessionLiveUrlsPage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Browserbase.AnyOf<global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.FunctionBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.FunctionBuildLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.InvocationLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.Invocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.FunctionVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.SearchWebResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.SessionLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Browserbase.SessionRecording>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}