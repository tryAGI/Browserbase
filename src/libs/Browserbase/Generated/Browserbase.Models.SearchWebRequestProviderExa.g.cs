
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequestProviderExa
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebRequestProviderExaProviderJsonConverter))]
        public global::Browserbase.SearchWebRequestProviderExaProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestProviderExaModeVariant1?, global::Browserbase.SearchWebRequestProviderExaModeVariant2?, global::Browserbase.SearchWebRequestProviderExaModeVariant3?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderExaModeVariant1?, global::Browserbase.SearchWebRequestProviderExaModeVariant2?, global::Browserbase.SearchWebRequestProviderExaModeVariant3?>? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestProviderExa" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequestProviderExa(
            global::Browserbase.SearchWebRequestProviderExaProvider provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderExaModeVariant1?, global::Browserbase.SearchWebRequestProviderExaModeVariant2?, global::Browserbase.SearchWebRequestProviderExaModeVariant3?>? mode)
        {
            this.Provider = provider;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestProviderExa" /> class.
        /// </summary>
        public SearchWebRequestProviderExa()
        {
        }

    }
}