
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestVariant1ModeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestVariant1ModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestVariant1ModeVariant1 value)
        {
            return value switch
            {
                SearchWebRequestVariant1ModeVariant1.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestVariant1ModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "fast" => SearchWebRequestVariant1ModeVariant1.Fast,
                _ => null,
            };
        }
    }
}