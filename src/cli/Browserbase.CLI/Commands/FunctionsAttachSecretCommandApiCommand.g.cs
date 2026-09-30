#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class FunctionsAttachSecretCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<global::System.Guid> SecretId { get; } = new(
        name: @"--secret-id")
    {
        Description = @"The id of the project secret to attach (the `id` returned by POST /v1/secrets). Idempotent: re-attaching an already-attached secret succeeds.",
        Required = true,
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"functions-attach-secret", @"Attach a Secret to a Function
Attach a secret to a Function, taking effect on the Function's next invocation. Note: Attaching a secret that is already attached succeeds to support idempotency.");
                        command.Arguments.Add(Id);
                        command.Options.Add(SecretId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var secretId = parseResult.GetRequiredValue(SecretId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.FunctionsAttachSecretAsync(
                                    id: id,
                                    secretId: secretId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}