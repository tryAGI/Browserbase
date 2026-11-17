
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderExaModeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Deep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderExaModeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderExaModeVariant3 value)
        {
            return value switch
            {
                SearchWebRequestProviderExaModeVariant3.Deep => "deep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderExaModeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "deep" => SearchWebRequestProviderExaModeVariant3.Deep,
                _ => null,
            };
        }
    }
}