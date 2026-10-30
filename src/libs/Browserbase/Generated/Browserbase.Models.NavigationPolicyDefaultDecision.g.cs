
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.
    /// </summary>
    public enum NavigationPolicyDefaultDecision
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
    public static class NavigationPolicyDefaultDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPolicyDefaultDecision value)
        {
            return value switch
            {
                NavigationPolicyDefaultDecision.Allow => "allow",
                NavigationPolicyDefaultDecision.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPolicyDefaultDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPolicyDefaultDecision.Allow,
                "block" => NavigationPolicyDefaultDecision.Block,
                _ => null,
            };
        }
    }
}