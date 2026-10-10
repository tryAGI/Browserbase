
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
        public global::Browserbase.SecretsCreateRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettings? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsContext? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsViewport? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsOs? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestProxySettings? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestRegion? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequestStatus? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequestEventType? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequestEventType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListStatus? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListStatus? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsListResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Agent>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRun>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponse? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItem? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessage? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Certificate>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.DownloadsListResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Download>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, object>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse2? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse5? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse6? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse7? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse8? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Function>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsListResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuild>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsGetLogsResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuildLog>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponse2? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCause? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCauseCode? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetLogsResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.InvocationLog>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionVersionsListInvocationsResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Invocation>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Secret>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse2? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse3? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse2? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse2? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListVersionsResponse? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionVersion>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Project>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseResult? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse2? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse2? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse2? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Session>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateResponse2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetResponse2? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLog>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse3? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse4? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse5? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse6? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse2? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse3? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse4? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse5? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse6? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetReplayResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.ReplayPage>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateResponse2? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksListResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Webhook>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretResponse? Type204 { get; set; }

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