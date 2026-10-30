
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// The project's navigation policies.
    /// </summary>
    public sealed partial class NavigationPoliciesListResponse
    {
        /// <summary>
        /// The project's navigation policies, ordered by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicy> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPoliciesListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The project's navigation policies, ordered by name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NavigationPoliciesListResponse(
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicy> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPoliciesListResponse" /> class.
        /// </summary>
        public NavigationPoliciesListResponse()
        {
        }

    }
}