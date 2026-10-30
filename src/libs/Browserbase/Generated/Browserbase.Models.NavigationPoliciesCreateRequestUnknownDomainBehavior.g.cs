
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.
    /// </summary>
    public enum NavigationPoliciesCreateRequestUnknownDomainBehavior
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
    public static class NavigationPoliciesCreateRequestUnknownDomainBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesCreateRequestUnknownDomainBehavior value)
        {
            return value switch
            {
                NavigationPoliciesCreateRequestUnknownDomainBehavior.Allow => "allow",
                NavigationPoliciesCreateRequestUnknownDomainBehavior.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesCreateRequestUnknownDomainBehavior? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NavigationPoliciesCreateRequestUnknownDomainBehavior.Allow,
                "block" => NavigationPoliciesCreateRequestUnknownDomainBehavior.Block,
                _ => null,
            };
        }
    }
}