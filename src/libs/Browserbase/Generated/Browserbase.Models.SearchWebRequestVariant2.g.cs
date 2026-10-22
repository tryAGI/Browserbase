
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebRequestVariant2ProviderJsonConverter))]
        public global::Browserbase.SearchWebRequestVariant2Provider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestVariant2ModeVariant1?, global::Browserbase.SearchWebRequestVariant2ModeVariant2?, global::Browserbase.SearchWebRequestVariant2ModeVariant3?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestVariant2ModeVariant1?, global::Browserbase.SearchWebRequestVariant2ModeVariant2?, global::Browserbase.SearchWebRequestVariant2ModeVariant3?>? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestVariant2" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequestVariant2(
            global::Browserbase.SearchWebRequestVariant2Provider provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestVariant2ModeVariant1?, global::Browserbase.SearchWebRequestVariant2ModeVariant2?, global::Browserbase.SearchWebRequestVariant2ModeVariant3?>? mode)
        {
            this.Provider = provider;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestVariant2" /> class.
        /// </summary>
        public SearchWebRequestVariant2()
        {
        }

    }
}