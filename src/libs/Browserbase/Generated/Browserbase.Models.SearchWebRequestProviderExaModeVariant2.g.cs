
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderExaModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        DeepLite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderExaModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderExaModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestProviderExaModeVariant2.DeepLite => "deep-lite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderExaModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "deep-lite" => SearchWebRequestProviderExaModeVariant2.DeepLite,
                _ => null,
            };
        }
    }
}