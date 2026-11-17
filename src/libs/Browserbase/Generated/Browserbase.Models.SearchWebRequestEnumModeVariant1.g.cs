
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumModeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumModeVariant1 value)
        {
            return value switch
            {
                SearchWebRequestEnumModeVariant1.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "fast" => SearchWebRequestEnumModeVariant1.Fast,
                _ => null,
            };
        }
    }
}