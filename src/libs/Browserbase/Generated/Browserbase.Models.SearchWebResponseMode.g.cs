
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// The search mode that served the request.
    /// </summary>
    public enum SearchWebResponseMode
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
        /// <summary>
        ///
        /// </summary>
        Deep,
        /// <summary>
        ///
        /// </summary>
        DeepLite,
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebResponseModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebResponseMode value)
        {
            return value switch
            {
                SearchWebResponseMode.Advanced => "advanced",
                SearchWebResponseMode.Deep => "deep",
                SearchWebResponseMode.DeepLite => "deep-lite",
                SearchWebResponseMode.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebResponseMode? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchWebResponseMode.Advanced,
                "deep" => SearchWebResponseMode.Deep,
                "deep-lite" => SearchWebResponseMode.DeepLite,
                "fast" => SearchWebResponseMode.Fast,
                _ => null,
            };
        }
    }
}