
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Size of the browser used for the session.
    /// </summary>
    public enum SessionSize
    {
        /// <summary>
        ///
        /// </summary>
        Large,
        /// <summary>
        ///
        /// </summary>
        Regular,
        /// <summary>
        ///
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionSize value)
        {
            return value switch
            {
                SessionSize.Large => "large",
                SessionSize.Regular => "regular",
                SessionSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => SessionSize.Large,
                "regular" => SessionSize.Regular,
                "xlarge" => SessionSize.Xlarge,
                _ => null,
            };
        }
    }
}