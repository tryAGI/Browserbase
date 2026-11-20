
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Size of the browser. Larger sizes provide more resources to improve performance for intensive tasks. Defaults to `regular`.<br/>
    /// Default Value: regular
    /// </summary>
    public enum FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize
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
    public static class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize value)
        {
            return value switch
            {
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Large => "large",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Regular => "regular",
                FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Large,
                "regular" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Regular,
                "xlarge" => FunctionsInvokeRequestSessionCreateParamsBrowserSettingsSize.Xlarge,
                _ => null,
            };
        }
    }
}