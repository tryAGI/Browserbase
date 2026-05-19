
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public enum FetchCreateRequestFormatVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchCreateRequestFormatVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchCreateRequestFormatVariant1 value)
        {
            return value switch
            {
                FetchCreateRequestFormatVariant1.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchCreateRequestFormatVariant1? ToEnum(string value)
        {
            return value switch
            {
                "raw" => FetchCreateRequestFormatVariant1.Raw,
                _ => null,
            };
        }
    }
}