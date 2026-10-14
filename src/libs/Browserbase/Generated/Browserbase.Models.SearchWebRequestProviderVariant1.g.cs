
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderVariant1 value)
        {
            return value switch
            {
                SearchWebRequestProviderVariant1.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => SearchWebRequestProviderVariant1.Parallel,
                _ => null,
            };
        }
    }
}