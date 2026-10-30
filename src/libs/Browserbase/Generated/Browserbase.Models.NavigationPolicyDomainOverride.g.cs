
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NavigationPolicyDomainOverride
    {
        /// <summary>
        /// Host the override applies to, for example `example.com`. Matching is case-insensitive and covers subdomains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Decision for navigations to this host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.NavigationPolicyDomainOverrideDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.NavigationPolicyDomainOverrideDecision Decision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPolicyDomainOverride" /> class.
        /// </summary>
        /// <param name="domain">
        /// Host the override applies to, for example `example.com`. Matching is case-insensitive and covers subdomains.
        /// </param>
        /// <param name="decision">
        /// Decision for navigations to this host.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NavigationPolicyDomainOverride(
            string domain,
            global::Browserbase.NavigationPolicyDomainOverrideDecision decision)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Decision = decision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPolicyDomainOverride" /> class.
        /// </summary>
        public NavigationPolicyDomainOverride()
        {
        }

    }
}