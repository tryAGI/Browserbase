
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NavigationPoliciesUpdateRequest
    {
        /// <summary>
        /// Display name. A policy's id identifies it, not its name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Free-form notes about the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the policy can be bound to new sessions. Running sessions keep the policy they started with. A disabled policy stays editable and can be re-enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDecision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.NavigationPoliciesUpdateRequestDefaultDecisionJsonConverter))]
        public global::Browserbase.NavigationPoliciesUpdateRequestDefaultDecision? DefaultDecision { get; set; }

        /// <summary>
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCategories")]
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>? AllowedCategories { get; set; }

        /// <summary>
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedCategories")]
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>? BlockedCategories { get; set; }

        /// <summary>
        /// Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknownDomainBehavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.NavigationPoliciesUpdateRequestUnknownDomainBehaviorJsonConverter))]
        public global::Browserbase.NavigationPoliciesUpdateRequestUnknownDomainBehavior? UnknownDomainBehavior { get; set; }

        /// <summary>
        /// Per-host decisions that take precedence over category rules and the default. Each host may appear once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainOverrides")]
        public global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>? DomainOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPoliciesUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name. A policy's id identifies it, not its name.
        /// </param>
        /// <param name="description">
        /// Free-form notes about the policy.
        /// </param>
        /// <param name="enabled">
        /// Whether the policy can be bound to new sessions. Running sessions keep the policy they started with. A disabled policy stays editable and can be re-enabled.
        /// </param>
        /// <param name="defaultDecision">
        /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
        /// </param>
        /// <param name="allowedCategories">
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </param>
        /// <param name="blockedCategories">
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </param>
        /// <param name="unknownDomainBehavior">
        /// Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.
        /// </param>
        /// <param name="domainOverrides">
        /// Per-host decisions that take precedence over category rules and the default. Each host may appear once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NavigationPoliciesUpdateRequest(
            string? name,
            string? description,
            bool? enabled,
            global::Browserbase.NavigationPoliciesUpdateRequestDefaultDecision? defaultDecision,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>? allowedCategories,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>? blockedCategories,
            global::Browserbase.NavigationPoliciesUpdateRequestUnknownDomainBehavior? unknownDomainBehavior,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>? domainOverrides)
        {
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.DefaultDecision = defaultDecision;
            this.AllowedCategories = allowedCategories;
            this.BlockedCategories = blockedCategories;
            this.UnknownDomainBehavior = unknownDomainBehavior;
            this.DomainOverrides = domainOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPoliciesUpdateRequest" /> class.
        /// </summary>
        public NavigationPoliciesUpdateRequest()
        {
        }

    }
}