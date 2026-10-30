
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Rules for which domains a browser session may navigate to. Bind a policy to a session with `browserSettings.riskPolicyId`; Browserbase then allows or blocks each navigation by the policy's overrides, its category rules, and finally its default decision. A session keeps the policy as it was when the session started: edits, disables, and deletes apply to sessions that start afterwards. A policy checks navigations: page loads, iframes, popups, and each redirect. It doesn't check requests a page makes itself, such as scripts, images, and `fetch` calls. In a session that loads a Context, pages skip their service workers so that the policy checks every navigation.
    /// </summary>
    public sealed partial class NavigationPolicy
    {
        /// <summary>
        /// Unique identifier for the navigation policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The project the policy belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Display name. A policy's id identifies it, not its name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-form notes about the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the policy can be bound to new sessions. Running sessions keep the policy they started with. A disabled policy stays editable and can be re-enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDecision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.NavigationPolicyDefaultDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.NavigationPolicyDefaultDecision DefaultDecision { get; set; }

        /// <summary>
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCategories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyAllowedCategorie> AllowedCategories { get; set; }

        /// <summary>
        /// Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedCategories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyBlockedCategorie> BlockedCategories { get; set; }

        /// <summary>
        /// Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknownDomainBehavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Browserbase.JsonConverters.NavigationPolicyUnknownDomainBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Browserbase.NavigationPolicyUnknownDomainBehavior UnknownDomainBehavior { get; set; }

        /// <summary>
        /// Per-host decisions that take precedence over category rules and the default. Each host may appear once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainOverrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyDomainOverride> DomainOverrides { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPolicy" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the navigation policy.
        /// </param>
        /// <param name="projectId">
        /// The project the policy belongs to.
        /// </param>
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
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NavigationPolicy(
            string id,
            string projectId,
            string name,
            string description,
            bool enabled,
            global::Browserbase.NavigationPolicyDefaultDecision defaultDecision,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyAllowedCategorie> allowedCategories,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyBlockedCategorie> blockedCategories,
            global::Browserbase.NavigationPolicyUnknownDomainBehavior unknownDomainBehavior,
            global::System.Collections.Generic.IList<global::Browserbase.NavigationPolicyDomainOverride> domainOverrides,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Enabled = enabled;
            this.DefaultDecision = defaultDecision;
            this.AllowedCategories = allowedCategories ?? throw new global::System.ArgumentNullException(nameof(allowedCategories));
            this.BlockedCategories = blockedCategories ?? throw new global::System.ArgumentNullException(nameof(blockedCategories));
            this.UnknownDomainBehavior = unknownDomainBehavior;
            this.DomainOverrides = domainOverrides ?? throw new global::System.ArgumentNullException(nameof(domainOverrides));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigationPolicy" /> class.
        /// </summary>
        public NavigationPolicy()
        {
        }

    }
}