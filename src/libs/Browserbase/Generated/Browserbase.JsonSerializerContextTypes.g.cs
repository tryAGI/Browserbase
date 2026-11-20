
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
        public global::System.Guid? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.BrowserbaseProxyConfigGeolocation? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Certificate? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Context? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Download? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Extension? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExternalProxyConfig? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExternalProxyConfigType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Function? Type18 { get; set; }
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
        public global::Browserbase.Label? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicy? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyDefaultDecision? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyAllowedCategorie>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyAllowedCategorie? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyBlockedCategorie>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyBlockedCategorie? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyUnknownDomainBehavior? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyDomainOverride>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyDomainOverride? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPolicyDomainOverrideDecision? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NoneProxyConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NoneProxyConfigType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Project? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ProjectUsage? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.RecordingDownload? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.RecordingDownloadStatus? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ReplayPage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Secret? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsKeypair? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Session? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionStatus? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionSize? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionRegion? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLiveUrls? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLiveUrlsPage>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLiveUrlsPage? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLog? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLogRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionLogResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.Webhook? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhookEventType>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhookEventType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsCreateRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestBrowserSettings? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestBrowserSettingsContext? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestBrowserSettingsProxySettings? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsCreateRequestVariables2? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsResumeRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsResumeRequestVariables2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsUpdateRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.CertificatesUploadRequest? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ExtensionsUploadRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.FetchCreateRequestFormatVariant1?, global::Browserbase.FetchCreateRequestFormatVariant2?, global::Browserbase.FetchCreateRequestFormatVariant3?>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant1? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant2? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateRequestFormatVariant3? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequest? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParams? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettings? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsOs? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsInvokeRequestSessionCreateParamsProxySettings? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsCreateRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsUpdateRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestDefaultDecision? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesCreateRequestAllowedCategorie>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestAllowedCategorie? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesCreateRequestBlockedCategorie>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestBlockedCategorie? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesCreateRequestDomainOverride>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestDomainOverride? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesCreateRequestDomainOverrideDecision? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequest? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestDefaultDecision? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestUnknownDomainBehavior? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesUpdateRequestDomainOverrideDecision? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestCategory? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderVariant1?, global::Browserbase.SearchWebRequestProviderVariant2?>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestProviderVariant2? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant1? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant2? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant3? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestModeVariant4? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnum? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumProvider? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestEnumModeVariant1?, global::Browserbase.SearchWebRequestEnumModeVariant2?>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumModeVariant1? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumModeVariant2? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnum2? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumProvider2? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestEnumModeVariant1?, global::Browserbase.SearchWebRequestEnumModeVariant22?, global::Browserbase.SearchWebRequestEnumModeVariant3?>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumModeVariant22? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnumModeVariant3? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebRequestEnum3? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateRequest? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateRequest? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequest? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettings? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsContext? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsViewport? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsOs? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestBrowserSettingsSize? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestProxySettings? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRequestRegion? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUpdateRequestStatus? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsRequest? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksCreateRequestEventType>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateRequestEventType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.WebhooksUpdateRequestEventType>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksUpdateRequestEventType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListStatus? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListStatus? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentsListResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Agent>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsListResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRun>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponse? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItem>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItem? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessage? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageRole? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Certificate>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.ContextsCreateResponse? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.DownloadsListResponse? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Download>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<string, object>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse2? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse5? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse6? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse7? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FetchCreateResponse8? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListResponse? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Function>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsListResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuild>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionBuildsGetLogsResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionBuildLog>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Invocation, global::Browserbase.InvocationsGetResponse2>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponse2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCause? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetResponseCauseCode? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.InvocationsGetLogsResponse? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.InvocationLog>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionVersionsListInvocationsResponse? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Invocation>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Secret>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse2? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListSecretsResponse3? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsAttachSecretResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsDetachSecretResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.FunctionsListVersionsResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.FunctionVersion>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsListResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Label>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsListResponse2? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsCreateResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsUpdateResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.LabelsDeleteResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.NavigationPoliciesListResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicy>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Project>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseProvider? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseMode? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SearchWebResponseResult>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SearchWebResponseResult? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsListResponse2? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsCreateResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsGetResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsDeleteResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SecretsUpdateResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Session>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateResponse2? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsGetResponse2>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetResponse2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionsGetResponseLabel>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetResponseLabel? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsResponse2? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsResponse3? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsResponse4? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsSetLabelsResponse5? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.SessionLog>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.RecordingDownload>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse2? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse3? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse4? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse5? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsCreateRecordingDownloadsResponse6? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse3? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse4? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse5? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsListRecordingDownloadsResponse6? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsGetReplayResponse? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.ReplayPage>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.SessionsUploadFileResponse? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AllOf<global::Browserbase.Webhook, global::Browserbase.WebhooksCreateResponse2>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksCreateResponse2? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksListResponse? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Browserbase.Webhook>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.WebhooksRotateSecretResponse? Type271 { get; set; }

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
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPolicyAllowedCategorie>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPolicyBlockedCategorie>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPolicyDomainOverride>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SessionLiveUrlsPage>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhookEventType>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.AnyOf<global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesCreateRequestAllowedCategorie>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesCreateRequestBlockedCategorie>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesCreateRequestDomainOverride>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhooksCreateRequestEventType>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.WebhooksUpdateRequestEventType>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Agent>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRun>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Browserbase.OneOf<string, global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.AgentRunsMessagesResponseDataItemMessageContentVariant2Item>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Certificate>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Download>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Function>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionBuild>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionBuildLog>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.InvocationLog>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Invocation>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Secret>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.FunctionVersion>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Label>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.NavigationPolicy>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Project>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SearchWebResponseResult>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Session>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SessionsGetResponseLabel>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.SessionLog>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.RecordingDownload>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.ReplayPage>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Browserbase.Webhook>? ListType44 { get; set; }
    }
}