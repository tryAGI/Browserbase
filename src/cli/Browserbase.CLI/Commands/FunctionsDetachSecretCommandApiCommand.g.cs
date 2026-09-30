#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class FunctionsDetachSecretCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Argument<global::System.Guid> SecretId { get; } = new(
        name: @"secret-id")
    {
        Description = @"",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"functions-detach-secret", @"Detach a Secret from a Function
Detach a secret from a Function, taking effect on the Function's next invocation. Note: Detaching a secret that is not attached succeeds to support idempotency.");
                        command.Arguments.Add(Id);
                        command.Arguments.Add(SecretId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var secretId = parseResult.GetRequiredValue(SecretId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.FunctionsDetachSecretAsync(
                                    id: id,
                                    secretId: secretId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}