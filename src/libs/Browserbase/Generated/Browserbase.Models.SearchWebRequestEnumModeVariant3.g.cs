
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumModeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Deep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumModeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumModeVariant3 value)
        {
            return value switch
            {
                SearchWebRequestEnumModeVariant3.Deep => "deep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumModeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "deep" => SearchWebRequestEnumModeVariant3.Deep,
                _ => null,
            };
        }
    }
}