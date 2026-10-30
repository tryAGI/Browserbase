
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for navigations to this host.
    /// </summary>
    public enum NavigationPoliciesUpdateRequestDomainOverrideDecision
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
    public static class NavigationPoliciesUpdateRequestDomainOverrideDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesUpdateRequestDomainOverrideDecision value)
        {
            return value switch
            {
                NavigationPoliciesUpdateRequestDomainOverrideDecision.Allow => "allow",
                NavigationPoliciesUpdateRequestDomainOverrideDecision.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesUpdateRequestDomainOverrideDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPoliciesUpdateRequestDomainOverrideDecision.Allow,
                "block" => NavigationPoliciesUpdateRequestDomainOverrideDecision.Block,
                _ => null,
            };
        }
    }
}