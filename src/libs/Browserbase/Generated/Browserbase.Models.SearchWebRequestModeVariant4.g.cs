
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestModeVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Deep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestModeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestModeVariant4 value)
        {
            return value switch
            {
                SearchWebRequestModeVariant4.Deep => "deep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestModeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "deep" => SearchWebRequestModeVariant4.Deep,
                _ => null,
            };
        }
    }
}