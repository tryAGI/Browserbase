#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class FunctionBuildCauseCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.FunctionBuildCauseCode>
    {
        /// <inheritdoc />
        public override global::Browserbase.FunctionBuildCauseCode Read(
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
                        return global::Browserbase.FunctionBuildCauseCodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.FunctionBuildCauseCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.FunctionBuildCauseCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.FunctionBuildCauseCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.FunctionBuildCauseCodeExtensions.ToValueString(value));
        }
    }
}
