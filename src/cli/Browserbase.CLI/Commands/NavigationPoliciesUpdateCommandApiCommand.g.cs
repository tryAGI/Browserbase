#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class NavigationPoliciesUpdateCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"The navigation policy ID.",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Display name. A policy's id identifies it, not its name.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Free-form notes about the policy.",
    };

    private static Option<bool?> Enabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enabled",
        description: @"Whether the policy can be bound to new sessions. Running sessions keep the policy they started with. A disabled policy stays editable and can be re-enabled.");

    private static Option<global::Browserbase.NavigationPoliciesUpdateRequestDefaultDecision?> DefaultDecision { get; } = new(
        name: @"--default-decision")
    {
        Description = @"Decision for each of a domain's categories that has no category rule. The strictest of a domain's category decisions applies, and overrides take precedence.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestAllowedCategorie>?> AllowedCategories { get; } = new(
        name: @"--allowed-categories")
    {
        Description = @"Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestBlockedCategorie>?> BlockedCategories { get; } = new(
        name: @"--blocked-categories")
    {
        Description = @"Navigation categories. Browserbase blocks a domain in any blocked category, even if it is also in an allowed one.",
    };

    private static Option<global::Browserbase.NavigationPoliciesUpdateRequestUnknownDomainBehavior?> UnknownDomainBehavior { get; } = new(
        name: @"--unknown-domain-behavior")
    {
        Description = @"Decision for a domain, or one of its categories, that Browserbase can't classify. It counts as one of the domain's category decisions, so the strictest still applies.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Browserbase.NavigationPoliciesUpdateRequestDomainOverride>?> DomainOverrides { get; } = new(
        name: @"--domain-overrides")
    {
        Description = @"Per-host decisions that take precedence over category rules and the default. Each host may appear once.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.NavigationPolicy value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.NavigationPolicy value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"navigation-policies-update", @"Update a Navigation Policy
Update a navigation policy. Omitted fields keep their values; a supplied list replaces the stored list rather than adding to it. The change applies to sessions that start afterwards; running sessions keep the policy they started with.");
                        command.Arguments.Add(Id);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Enabled);
                        command.Options.Add(DefaultDecision);
                        command.Options.Add(AllowedCategories);
                        command.Options.Add(BlockedCategories);
                        command.Options.Add(UnknownDomainBehavior);
                        command.Options.Add(DomainOverrides);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.NavigationPoliciesUpdateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                        var defaultDecision = CliRuntime.WasSpecified(parseResult, DefaultDecision) ? parseResult.GetValue(DefaultDecision) : (__requestBase is { } __DefaultDecisionBaseValue ? __DefaultDecisionBaseValue.DefaultDecision : default);
                        var allowedCategories = CliRuntime.WasSpecified(parseResult, AllowedCategories) ? parseResult.GetValue(AllowedCategories) : (__requestBase is { } __AllowedCategoriesBaseValue ? __AllowedCategoriesBaseValue.AllowedCategories : default);
                        var blockedCategories = CliRuntime.WasSpecified(parseResult, BlockedCategories) ? parseResult.GetValue(BlockedCategories) : (__requestBase is { } __BlockedCategoriesBaseValue ? __BlockedCategoriesBaseValue.BlockedCategories : default);
                        var unknownDomainBehavior = CliRuntime.WasSpecified(parseResult, UnknownDomainBehavior) ? parseResult.GetValue(UnknownDomainBehavior) : (__requestBase is { } __UnknownDomainBehaviorBaseValue ? __UnknownDomainBehaviorBaseValue.UnknownDomainBehavior : default);
                        var domainOverrides = CliRuntime.WasSpecified(parseResult, DomainOverrides) ? parseResult.GetValue(DomainOverrides) : (__requestBase is { } __DomainOverridesBaseValue ? __DomainOverridesBaseValue.DomainOverrides : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.NavigationPoliciesUpdateAsync(
                                    id: id,
                                    name: name,
                                    description: description,
                                    enabled: enabled,
                                    defaultDecision: defaultDecision,
                                    allowedCategories: allowedCategories,
                                    blockedCategories: blockedCategories,
                                    unknownDomainBehavior: unknownDomainBehavior,
                                    domainOverrides: domainOverrides,
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