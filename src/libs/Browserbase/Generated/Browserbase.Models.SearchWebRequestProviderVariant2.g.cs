
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestProviderVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestProviderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestProviderVariant2 value)
        {
            return value switch
            {
                SearchWebRequestProviderVariant2.Exa => "exa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestProviderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "exa" => SearchWebRequestProviderVariant2.Exa,
                _ => null,
            };
        }
    }
}