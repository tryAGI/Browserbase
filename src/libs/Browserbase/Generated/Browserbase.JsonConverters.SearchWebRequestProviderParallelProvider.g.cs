#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchWebRequestProviderParallelProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.SearchWebRequestProviderParallelProvider>
    {
        /// <inheritdoc />
        public override global::Browserbase.SearchWebRequestProviderParallelProvider Read(
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
                        return global::Browserbase.SearchWebRequestProviderParallelProviderExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown value '{stringValue}' for global::Browserbase.SearchWebRequestProviderParallelProvider.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.SearchWebRequestProviderParallelProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.SearchWebRequestProviderParallelProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.SearchWebRequestProviderParallelProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.SearchWebRequestProviderParallelProviderExtensions.ToValueString(value));
        }
    }
}
