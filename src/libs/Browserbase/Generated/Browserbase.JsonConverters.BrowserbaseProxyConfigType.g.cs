#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class BrowserbaseProxyConfigTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.BrowserbaseProxyConfigType>
    {
        /// <inheritdoc />
        public override global::Browserbase.BrowserbaseProxyConfigType Read(
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
                        return global::Browserbase.BrowserbaseProxyConfigTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.BrowserbaseProxyConfigType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.BrowserbaseProxyConfigType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.BrowserbaseProxyConfigType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.BrowserbaseProxyConfigTypeExtensions.ToValueString(value));
        }
    }
}
