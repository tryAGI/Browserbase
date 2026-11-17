
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumProvider
    {
        /// <summary>
        ///
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumProvider value)
        {
            return value switch
            {
                SearchWebRequestEnumProvider.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumProvider? ToEnum(string value)
        {
            return value switch
            {
                "parallel" => SearchWebRequestEnumProvider.Parallel,
                _ => null,
            };
        }
    }
}