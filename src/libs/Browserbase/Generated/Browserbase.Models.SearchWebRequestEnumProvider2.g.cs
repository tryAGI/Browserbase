
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchWebRequestEnumProvider2
    {
        /// <summary>
        ///
        /// </summary>
        Exa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestEnumProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestEnumProvider2 value)
        {
            return value switch
            {
                SearchWebRequestEnumProvider2.Exa => "exa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestEnumProvider2? ToEnum(string value)
        {
            return value switch
            {
                "exa" => SearchWebRequestEnumProvider2.Exa,
                _ => null,
            };
        }
    }
}