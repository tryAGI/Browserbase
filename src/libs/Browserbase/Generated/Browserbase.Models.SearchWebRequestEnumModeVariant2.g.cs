
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestEnumModeVariant2.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchWebRequestEnumModeVariant2.Advanced,
                _ => null,
            };
        }
    }
}