#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class FetchCreateRequestFormatVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.FetchCreateRequestFormatVariant1>
    {
        /// <inheritdoc />
        public override global::Browserbase.FetchCreateRequestFormatVariant1 Read(
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
                        return global::Browserbase.FetchCreateRequestFormatVariant1Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.FetchCreateRequestFormatVariant1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.FetchCreateRequestFormatVariant1);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.FetchCreateRequestFormatVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.FetchCreateRequestFormatVariant1Extensions.ToValueString(value));
        }
    }
}
