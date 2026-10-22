
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestModeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        DeepLite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestModeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestModeVariant3 value)
        {
            return value switch
            {
                SearchWebRequestModeVariant3.DeepLite => "deep-lite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestModeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "deep-lite" => SearchWebRequestModeVariant3.DeepLite,
                _ => null,
            };
        }
    }
}