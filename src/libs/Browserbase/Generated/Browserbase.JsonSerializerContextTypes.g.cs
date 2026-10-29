
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant1? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant2? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant2? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant3? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant4? Type99 { get; set; }
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
        public global::Browserbase.SearchWebRequestVariant2ModeVariant1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant2ModeVariant2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant2ModeVariant3? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestVariant3? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettings? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsContext? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsViewport? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsOs? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestProxySettings? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestRegion? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequestStatus? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequest? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequestEventType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequestEventType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListStatus? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListStatus? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsListResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Agent>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRun>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItem? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessage? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Certificate>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.DownloadsListResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Download>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, object>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse2? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse5? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse6? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse7? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse8? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Function>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsListResponse? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuild>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsGetLogsResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuildLog>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponse2? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCause? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCauseCode? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetLogsResponse? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.InvocationLog>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionVersionsListInvocationsResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Invocation>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Secret>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse3? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse2? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse2? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListVersionsResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionVersion>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Project>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponse? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseResult? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse2? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse2? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse2? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Session>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateResponse2? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetResponse2? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLog>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse3? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse4? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse5? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse6? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse3? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse4? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse5? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse6? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetReplayResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.ReplayPage>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateResponse2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksListResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Webhook>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretResponse? Type221 { get; set; }

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