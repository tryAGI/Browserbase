#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExternalProxyConfigTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.ExternalProxyConfigType>
    {
        /// <inheritdoc />
        public override global::Browserbase.ExternalProxyConfigType Read(
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
                        return global::Browserbase.ExternalProxyConfigTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.ExternalProxyConfigType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.ExternalProxyConfigType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.ExternalProxyConfigType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.ExternalProxyConfigTypeExtensions.ToValueString(value));
        }
    }
}
