#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionBuildStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.FunctionBuildStatus>
    {
        /// <inheritdoc />
        public override global::Browserbase.FunctionBuildStatus Read(
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
                        return global::Browserbase.FunctionBuildStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.FunctionBuildStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.FunctionBuildStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.FunctionBuildStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.FunctionBuildStatusExtensions.ToValueString(value));
        }
    }
}
