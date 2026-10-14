
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestVariant2Provider
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestVariant2Provider value)
        {
            return value switch
            {
                SearchWebRequestVariant2Provider.Exa => "exa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "exa" => SearchWebRequestVariant2Provider.Exa,
                _ => null,
            };
        }
    }
}