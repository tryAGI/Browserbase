
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestVariant2ModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        DeepLite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestVariant2ModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestVariant2ModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestVariant2ModeVariant2.DeepLite => "deep-lite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestVariant2ModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "deep-lite" => SearchWebRequestVariant2ModeVariant2.DeepLite,
                _ => null,
            };
        }
    }
}