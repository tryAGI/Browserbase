
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Size of the browser. Larger sizes provide more resources to improve performance for intensive tasks. Defaults to `regular`.<br/>
    /// Default Value: regular
    /// </summary>
    public enum SessionsCreateRequestBrowserSettingsSize
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
    public static class SessionsCreateRequestBrowserSettingsSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsCreateRequestBrowserSettingsSize value)
        {
            return value switch
            {
                SessionsCreateRequestBrowserSettingsSize.Large => "large",
                SessionsCreateRequestBrowserSettingsSize.Regular => "regular",
                SessionsCreateRequestBrowserSettingsSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsCreateRequestBrowserSettingsSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => SessionsCreateRequestBrowserSettingsSize.Large,
                "regular" => SessionsCreateRequestBrowserSettingsSize.Regular,
                "xlarge" => SessionsCreateRequestBrowserSettingsSize.Xlarge,
                _ => null,
            };
        }
    }
}