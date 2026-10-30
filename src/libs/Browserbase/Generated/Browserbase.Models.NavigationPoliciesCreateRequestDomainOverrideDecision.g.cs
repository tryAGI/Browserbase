
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for navigations to this host.
    /// </summary>
    public enum NavigationPoliciesCreateRequestDomainOverrideDecision
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NavigationPoliciesCreateRequestDomainOverrideDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesCreateRequestDomainOverrideDecision value)
        {
            return value switch
            {
                NavigationPoliciesCreateRequestDomainOverrideDecision.Allow => "allow",
                NavigationPoliciesCreateRequestDomainOverrideDecision.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesCreateRequestDomainOverrideDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPoliciesCreateRequestDomainOverrideDecision.Allow,
                "block" => NavigationPoliciesCreateRequestDomainOverrideDecision.Block,
                _ => null,
            };
        }
    }
}