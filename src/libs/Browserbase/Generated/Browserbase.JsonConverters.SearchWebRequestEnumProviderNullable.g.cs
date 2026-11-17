#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchWebRequestEnumProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.SearchWebRequestEnumProvider?>
    {
        /// <inheritdoc />
        public override global::Browserbase.SearchWebRequestEnumProvider? Read(
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
                        return global::Browserbase.SearchWebRequestEnumProviderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.SearchWebRequestEnumProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.SearchWebRequestEnumProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.SearchWebRequestEnumProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Browserbase.SearchWebRequestEnumProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
