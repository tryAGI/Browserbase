#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class AgentRunsCreateCommandApiCommand
{
    private static Option<string?> AgentId { get; } = new(
        name: @"--agent-id")
    {
        Description = @"Optionally run a specific [custom agent](/reference/api/create-an-agent) you've created by ID. The run will use the agent's `systemPrompt` and `resultSchema` unless overridden.",
    };

    private static Option<string> Task { get; } = new(
        name: @"--task")
    {
        Description = @"A natural language description of the task the agent should accomplish.",
        Required = true,
    };

    private static Option<object?> ResultSchema { get; } = new(
        name: @"--result-schema")
    {
        Description = @"An optional [JSON Schema](https://json-schema.org/specification) object. If provided, the agent will aim to return a `result` that conforms to this schema when the run completes. Overrides the referenced agent's default `resultSchema` for this run only.",
    };

    private static Option<global::Browserbase.AgentRunsCreateRequestBrowserSettings?> BrowserSettings { get; } = new(
        name: @"--browser-settings")
    {
        Description = @"Browser configuration for the agent's session. When omitted, runner defaults apply.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, global::Browserbase.AgentRunsCreateRequestVariables2>?> Variables { get; } = new(
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
        var command = new Command(@"agent-runs-create", @"Run an Agent
Run a browser agent to complete the `task` by using web search and browser tooling. Optionally pass `agentId` to run a [custom agent](/reference/api/create-an-agent) you've created.");
                        command.Options.Add(AgentId);
                        command.Options.Add(Task);
                        command.Options.Add(ResultSchema);
                        command.Options.Add(BrowserSettings);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.AgentRunsCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var agentId = CliRuntime.WasSpecified(parseResult, AgentId) ? parseResult.GetValue(AgentId) : (__requestBase is { } __AgentIdBaseValue ? __AgentIdBaseValue.AgentId : default);
                        var task = parseResult.GetRequiredValue(Task);
                        var resultSchema = CliRuntime.WasSpecified(parseResult, ResultSchema) ? parseResult.GetValue(ResultSchema) : (__requestBase is { } __ResultSchemaBaseValue ? __ResultSchemaBaseValue.ResultSchema : default);
                        var browserSettings = CliRuntime.WasSpecified(parseResult, BrowserSettings) ? parseResult.GetValue(BrowserSettings) : (__requestBase is { } __BrowserSettingsBaseValue ? __BrowserSettingsBaseValue.BrowserSettings : default);
                        var variables = CliRuntime.WasSpecified(parseResult, Variables) ? parseResult.GetValue(Variables) : (__requestBase is { } __VariablesBaseValue ? __VariablesBaseValue.Variables : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AgentRunsCreateAsync(
                                    agentId: agentId,
                                    task: task,
                                    resultSchema: resultSchema,
                                    browserSettings: browserSettings,
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