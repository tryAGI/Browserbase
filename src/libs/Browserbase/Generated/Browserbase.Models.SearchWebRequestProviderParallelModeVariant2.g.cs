
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderParallelModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderParallelModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderParallelModeVariant2 value)
        {
            return value switch
            {
                SearchWebRequestProviderParallelModeVariant2.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderParallelModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchWebRequestProviderParallelModeVariant2.Advanced,
                _ => null,
            };
        }
    }
}