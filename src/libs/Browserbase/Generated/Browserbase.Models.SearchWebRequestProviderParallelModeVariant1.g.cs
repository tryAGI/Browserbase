
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderParallelModeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderParallelModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderParallelModeVariant1 value)
        {
            return value switch
            {
                SearchWebRequestProviderParallelModeVariant1.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderParallelModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "fast" => SearchWebRequestProviderParallelModeVariant1.Fast,
                _ => null,
            };
        }
    }
}