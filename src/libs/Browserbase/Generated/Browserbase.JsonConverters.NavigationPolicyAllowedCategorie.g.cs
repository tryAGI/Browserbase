#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class NavigationPolicyAllowedCategorieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.NavigationPolicyAllowedCategorie>
    {
        /// <inheritdoc />
        public override global::Browserbase.NavigationPolicyAllowedCategorie Read(
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
                        return global::Browserbase.NavigationPolicyAllowedCategorieExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.NavigationPolicyAllowedCategorie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.NavigationPolicyAllowedCategorie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.NavigationPolicyAllowedCategorie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Browserbase.NavigationPolicyAllowedCategorieExtensions.ToValueString(value));
        }
    }
}
