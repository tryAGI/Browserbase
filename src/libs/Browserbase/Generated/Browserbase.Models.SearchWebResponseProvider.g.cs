
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// The search provider that served the request. Can differ from the documented default when the project or the filters select another provider.
    /// </summary>
    public enum SearchWebResponseProvider
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
        /// <summary>
        ///
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebResponseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebResponseProvider value)
        {
            return value switch
            {
                SearchWebResponseProvider.Exa => "exa",
                SearchWebResponseProvider.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebResponseProvider? ToEnum(string value)
        {
            return value switch
            {
                "exa" => SearchWebResponseProvider.Exa,
                "parallel" => SearchWebResponseProvider.Parallel,
                _ => null,
            };
        }
    }
}