
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumModeVariant22
    {
        /// <summary>
        ///
        /// </summary>
        DeepLite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumModeVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumModeVariant22 value)
        {
            return value switch
            {
                SearchWebRequestEnumModeVariant22.DeepLite => "deep-lite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumModeVariant22? ToEnum(string value)
        {
            return value switch
            {
                "deep-lite" => SearchWebRequestEnumModeVariant22.DeepLite,
                _ => null,
            };
        }
    }
}