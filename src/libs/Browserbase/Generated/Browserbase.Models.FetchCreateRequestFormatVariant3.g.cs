
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public enum FetchCreateRequestFormatVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchCreateRequestFormatVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchCreateRequestFormatVariant3 value)
        {
            return value switch
            {
                FetchCreateRequestFormatVariant3.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchCreateRequestFormatVariant3? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => FetchCreateRequestFormatVariant3.Markdown,
                _ => null,
            };
        }
    }
}