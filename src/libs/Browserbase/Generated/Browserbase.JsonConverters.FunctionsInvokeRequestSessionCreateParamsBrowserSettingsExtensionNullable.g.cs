#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension?>
    {
        /// <inheritdoc />
        public override global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtension? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Browserbase.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsExtensionExtensions.ToValueString(value.Value));
            }
        }
    }
}
