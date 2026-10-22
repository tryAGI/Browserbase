
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchWebRequestVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public object? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestVariant3" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWebRequestVariant3(
            object? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWebRequestVariant3" /> class.
        /// </summary>
        public SearchWebRequestVariant3()
        {
        }

    }
}