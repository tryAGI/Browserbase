#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class SecretsCreateCommandApiCommand
{
    private static Option<string> SecretKey { get; } = new(
        name: @"--secret-key")
    {
        Description = @"The name to store the secret value under.",
        Required = true,
    };

    private static Option<string> SealedSecretValue { get; } = new(
        name: @"--sealed-secret-value")
    {
        Description = @"The secret value encrypted with HPKE. To seal the secret value before sending, get the project's public key from GET /v1/secrets/keypair. Decode the publicKey using base64 into the raw 32-byte public key. Then, use HPKE Base mode (RFC 9180) with the following algorithm suite: DHKEM(X25519, HKDF-SHA256), HKDF-SHA256, and AES-256-GCM. Set both info and additional authenticated data (AAD) to an empty byte string. Then, create a new sender context using the public key and these settings, and encrypt the secret value as one message. Put the 32-byte encapsulated key before the ciphertext and keep the authentication tag at the end of the ciphertext. Encode the combined bytes with standard base64. Send the result as sealedSecretValue: base64(enc || ciphertext)",
        Required = true,
    };

    private static Option<string> KeypairId { get; } = new(
        name: @"--keypair-id")
    {
        Description = @"The `id` returned by GET /v1/secrets/keypair, identifying the keypair whose public key encrypted the value. Recorded with the secret so decryption stays correct across keypair rotation.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.Secret value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.Secret value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"secrets-create", @"Create a Secret");
                        command.Options.Add(SecretKey);
                        command.Options.Add(SealedSecretValue);
                        command.Options.Add(KeypairId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var secretKey = parseResult.GetRequiredValue(SecretKey);
                        var sealedSecretValue = parseResult.GetRequiredValue(SealedSecretValue);
                        var keypairId = parseResult.GetRequiredValue(KeypairId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SecretsCreateAsync(
                                    secretKey: secretKey,
                                    sealedSecretValue: sealedSecretValue,
                                    keypairId: keypairId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Browserbase.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}