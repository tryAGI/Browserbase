
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
    /// </summary>
    public enum NavigationPoliciesCreateRequestDefaultDecision
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
    public static class NavigationPoliciesCreateRequestDefaultDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesCreateRequestDefaultDecision value)
        {
            return value switch
            {
                NavigationPoliciesCreateRequestDefaultDecision.Allow => "allow",
                NavigationPoliciesCreateRequestDefaultDecision.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesCreateRequestDefaultDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPoliciesCreateRequestDefaultDecision.Allow,
                "block" => NavigationPoliciesCreateRequestDefaultDecision.Block,
                _ => null,
            };
        }
    }
}