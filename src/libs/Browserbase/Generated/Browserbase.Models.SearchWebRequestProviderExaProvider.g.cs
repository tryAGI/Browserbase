
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderExaProvider
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderExaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderExaProvider value)
        {
            return value switch
            {
                SearchWebRequestProviderExaProvider.Exa => "exa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderExaProvider? ToEnum(string value)
        {
            return value switch
            {
                "exa" => SearchWebRequestProviderExaProvider.Exa,
                _ => null,
            };
        }
    }
}