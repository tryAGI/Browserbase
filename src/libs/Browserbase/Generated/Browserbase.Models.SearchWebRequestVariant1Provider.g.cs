
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestVariant1Provider
    {
        /// <summary>
        ///
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestVariant1Provider value)
        {
            return value switch
            {
                SearchWebRequestVariant1Provider.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => SearchWebRequestVariant1Provider.Parallel,
                _ => null,
            };
        }
    }
}