
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Agent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRun? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunStatus? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunCause? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.BrowserbaseProxyConfig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.BrowserbaseProxyConfigType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.BrowserbaseProxyConfigGeolocation? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Certificate? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Context? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Download? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Extension? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExternalProxyConfig? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExternalProxyConfigType? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Function? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuild? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildStatus? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildBuiltFunction? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionVersion? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildCause? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildCauseCode? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildLog? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Invocation? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationStatus? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<object>, object>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationLog? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NoneProxyConfig? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NoneProxyConfigType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Project? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ProjectUsage? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.RecordingDownload? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.RecordingDownloadStatus? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ReplayPage? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Secret? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsKeypair? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Session? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionStatus? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionRegion? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLiveUrls? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLiveUrlsPage>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLiveUrlsPage? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLog? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLogRequest? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLogResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Webhook? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhookEventType>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhookEventType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsCreateRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestBrowserSettings? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestBrowserSettingsContext? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestVariables2? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsResumeRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsResumeRequestVariables2? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsUpdateRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.CertificatesUploadRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExtensionsUploadRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant1? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant2? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant3? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParams? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant1? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant2? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestModeVariant1?, global::Browserbase.SearchWebRequestModeVariant2?>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant1? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant2? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant1? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant1Provider? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestVariant1ModeVariant1?, global::Browserbase.SearchWebRequestVariant1ModeVariant2?>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant1ModeVariant1? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant1ModeVariant2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant2Provider? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettings? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsContext? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsViewport? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsOs? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestProxySettings? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestRegion? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequestStatus? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequestEventType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequestEventType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListStatus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsListResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Agent>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRun>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItem? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessage? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Certificate>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.DownloadsListResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Download>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, object>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse2? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse5? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse6? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse7? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse8? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListResponse? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Function>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsListResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuild>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsGetLogsResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuildLog>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponse2? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCause? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCauseCode? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetLogsResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.InvocationLog>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionVersionsListInvocationsResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Invocation>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Secret>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse3? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse2? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse2? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListVersionsResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionVersion>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Project>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponse? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseResult? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse2? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse2? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse2? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse2? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Session>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateResponse2? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetResponse2? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLog>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse2? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse3? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse4? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse5? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse6? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse2? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse3? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse4? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse5? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse6? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetReplayResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.ReplayPage>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateResponse2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksListResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Webhook>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretResponse? Type217 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AllOf<global::Browserbase.Function, global::Browserbase.FunctionBuildBuiltFunction>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<object>, object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SessionLiveUrlsPage>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhookEventType>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhooksCreateRequestEventType>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhooksUpdateRequestEventType>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Agent>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRun>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Certificate>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Download>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Function>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionBuild>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionBuildLog>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.InvocationLog>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Invocation>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Secret>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionVersion>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Project>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SearchWebResponseResult>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Session>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SessionLog>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.RecordingDownload>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.ReplayPage>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Webhook>? ListType32 { get; set; }
    }
}