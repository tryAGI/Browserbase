
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequestProviderParallel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.SearchWebRequestProviderParallelProviderJsonConverter))]
        public global::Browserbase.SearchWebRequestProviderParallelProvider Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.AnyOfJsonConverter<global::Browserbase.SearchWebRequestProviderParallelModeVariant1?, global::Browserbase.SearchWebRequestProviderParallelModeVariant2?>))]
        public global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderParallelModeVariant1?, global::Browserbase.SearchWebRequestProviderParallelModeVariant2?>? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestProviderParallel" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequestProviderParallel(
            global::Browserbase.SearchWebRequestProviderParallelProvider provider,
            global::Browserbase.AnyOf<global::Browserbase.SearchWebRequestProviderParallelModeVariant1?, global::Browserbase.SearchWebRequestProviderParallelModeVariant2?>? mode)
        {
            this.Provider = provider;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestProviderParallel" /> class.
        /// </summary>
        public SearchWebRequestProviderParallel()
        {
        }

    }
}