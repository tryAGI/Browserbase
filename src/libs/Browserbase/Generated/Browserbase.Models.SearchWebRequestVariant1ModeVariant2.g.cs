
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestVariant1ModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestVariant1ModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestVariant1ModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestVariant1ModeVariant2.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestVariant1ModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchWebRequestVariant1ModeVariant2.Advanced,
                _ => null,
            };
        }
    }
}