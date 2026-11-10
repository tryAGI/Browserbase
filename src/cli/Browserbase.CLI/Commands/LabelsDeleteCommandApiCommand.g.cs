#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class LabelsDeleteCommandApiCommand
{
    private static Argument<global::System.Guid> LabelId { get; } = new(
        name: @"label-id")
    {
        Description = @"The label's identifier.",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"labels-delete", @"Delete a Label
Delete a label and its session assignments, preserving the sessions. Missing and other-project labels are successful no-ops.");
                        command.Arguments.Add(LabelId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var labelId = parseResult.GetRequiredValue(LabelId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.LabelsDeleteAsync(
                                    labelId: labelId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}