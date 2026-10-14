
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestModeVariant2.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchWebRequestModeVariant2.Advanced,
                _ => null,
            };
        }
    }
}