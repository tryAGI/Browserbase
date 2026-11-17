
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderExaModeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderExaModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderExaModeVariant1 value)
        {
            return value switch
            {
                SearchWebRequestProviderExaModeVariant1.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderExaModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "fast" => SearchWebRequestProviderExaModeVariant1.Fast,
                _ => null,
            };
        }
    }
}