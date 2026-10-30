
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for navigations to this host.
    /// </summary>
    public enum NavigationPolicyDomainOverrideDecision
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
    public static class NavigationPolicyDomainOverrideDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPolicyDomainOverrideDecision value)
        {
            return value switch
            {
                NavigationPolicyDomainOverrideDecision.Allow => "allow",
                NavigationPolicyDomainOverrideDecision.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPolicyDomainOverrideDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPolicyDomainOverrideDecision.Allow,
                "block" => NavigationPolicyDomainOverrideDecision.Block,
                _ => null,
            };
        }
    }
}