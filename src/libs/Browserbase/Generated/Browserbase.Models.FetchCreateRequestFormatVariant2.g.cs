
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public enum FetchCreateRequestFormatVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FetchCreateRequestFormatVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FetchCreateRequestFormatVariant2 value)
        {
            return value switch
            {
                FetchCreateRequestFormatVariant2.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FetchCreateRequestFormatVariant2? ToEnum(string value)
        {
            return value switch
            {
                "json" => FetchCreateRequestFormatVariant2.Json,
                _ => null,
            };
        }
    }
}