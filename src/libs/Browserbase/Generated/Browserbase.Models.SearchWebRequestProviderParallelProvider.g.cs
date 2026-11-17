
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderParallelProvider
    {
        /// <summary>
        ///
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderParallelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderParallelProvider value)
        {
            return value switch
            {
                SearchWebRequestProviderParallelProvider.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderParallelProvider? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => SearchWebRequestProviderParallelProvider.Parallel,
                _ => null,
            };
        }
    }
}