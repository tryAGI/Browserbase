
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequestEnum2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebRequestEnumProvider2JsonConverter))]
        public global::Browserbase.SearchWebRequestEnumProvider2 Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestEnumModeVariant1?, global::Browserbase.SearchWebRequestEnumModeVariant22?, global::Browserbase.SearchWebRequestEnumModeVariant3?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestEnumModeVariant1?, global::Browserbase.SearchWebRequestEnumModeVariant22?, global::Browserbase.SearchWebRequestEnumModeVariant3?>? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestEnum2" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequestEnum2(
            global::Browserbase.SearchWebRequestEnumProvider2 provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestEnumModeVariant1?, global::Browserbase.SearchWebRequestEnumModeVariant22?, global::Browserbase.SearchWebRequestEnumModeVariant3?>? mode)
        {
            this.Provider = provider;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestEnum2" /> class.
        /// </summary>
        public SearchWebRequestEnum2()
        {
        }

    }
}