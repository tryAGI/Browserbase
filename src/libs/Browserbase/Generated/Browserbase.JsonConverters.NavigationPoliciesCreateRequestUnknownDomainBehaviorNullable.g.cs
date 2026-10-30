#nullable enable

namespace Browserbase.JsonConverters
{
    /// <inheritdoc />
    public sealed class NavigationPoliciesCreateRequestUnknownDomainBehaviorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior?>
    {
        /// <inheritdoc />
        public override global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior? Read(
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
                        return global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehaviorExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehavior? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Browserbase.NavigationPoliciesCreateRequestUnknownDomainBehaviorExtensions.ToValueString(value.Value));
            }
        }
    }
}
