#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class AgentRunsResumeCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"The run ID.",
    };

    private static Option<string?> Task { get; } = new(
        name: @"--task")
    {
        Description = @"Additional input for the agent: the reply to its request for input, which is the trailing `pause` tool call in the run's messages (e.g. an answer or an approval). Delivered to the agent as the result of that pause call.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsResumeRequestVariables2>?> Variables { get; } = new(
        name: @"--variables")
    {
        Description = @"Optional named variables the agent can reference as placeholders, i.e. `%variable%`. Each entry pairs a `value` the placeholder resolves to with an optional `description` that hints to the agent when it should be used. Values are not persisted.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AgentRun value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AgentRun value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"agent-runs-resume", @"Resume a Run
Resume a `PAUSED` run with additional input. The reply in `task` is delivered to the agent as the answer to its pause request (the trailing `pause` tool call in the run's messages), and `variables` merge over the run's original variables. Resuming a run that is not paused returns a conflict.");
                        command.Arguments.Add(RunId);
                        command.Options.Add(Task);
                        command.Options.Add(Variables);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.AgentRunsResumeRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var task = CliRuntime.WasSpecified(parseResult, Task) ? parseResult.GetValue(Task) : (__requestBase is { } __TaskBaseValue ? __TaskBaseValue.Task : default);
                        var variables = CliRuntime.WasSpecified(parseResult, Variables) ? parseResult.GetValue(Variables) : (__requestBase is { } __VariablesBaseValue ? __VariablesBaseValue.Variables : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentRunsResumeAsync(
                                    runId: runId,
                                    task: task,
                                    variables: variables,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Browserbase.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}