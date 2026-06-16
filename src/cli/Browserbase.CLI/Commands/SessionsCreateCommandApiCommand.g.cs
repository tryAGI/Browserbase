#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static partial class SessionsCreateCommandApiCommand
{
    private static Option<string?> ProjectId { get; } = new(
        name: @"--project-id")
    {
        Description = @"The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.",
    };

    private static Option<string?> ExtensionId { get; } = new(
        name: @"--extension-id")
    {
        Description = @"The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).",
    };

    private static Option<global::Browserbase.SessionsCreateRequestBrowserSettings?> BrowserSettings { get; } = new(
        name: @"--browser-settings")
    {
        Description = @"",
    };

    private static Option<int?> Timeout { get; } = new(
        name: @"--timeout")
    {
        Description = @"Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.",
    };

    private static Option<bool?> KeepAlive { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--keep-alive",
        description: @"Set to true to keep the session alive even after disconnections. Available on the Hobby Plan and above.");

    private static Option<global::Browserbase.AnyOf<global::System.Collections.Generic.IList<global::Browserbase.AnyOf<global::Browserbase.BrowserbaseProxyConfig, global::Browserbase.ExternalProxyConfig, global::Browserbase.NoneProxyConfig>>, bool?>?> Proxies { get; } = new(
        name: @"--proxies")
    {
        Description = @"Proxy configuration. Can be true for default proxy, or an array of proxy configurations.",
    };

    private static Option<global::Browserbase.SessionsCreateRequestProxySettings?> ProxySettings { get; } = new(
        name: @"--proxy-settings")
    {
        Description = @"Supplementary proxy settings. Optional.",
    };

    private static Option<global::Browserbase.SessionsCreateRequestRegion?> Region { get; } = new(
        name: @"--region")
    {
        Description = @"The region where the Session should run.",
    };

    private static Option<object?> UserMetadata { get; } = new(
        name: @"--user-metadata")
    {
        Description = @"Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).",
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

                    private static string FormatResponse(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Browserbase.AllOf<global::Browserbase.Session, global::Browserbase.SessionsCreateResponse2> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"sessions-create", @"Create a Session");
                        command.Options.Add(ProjectId);
                        command.Options.Add(ExtensionId);
                        command.Options.Add(BrowserSettings);
                        command.Options.Add(Timeout);
                        command.Options.Add(KeepAlive);
                        command.Options.Add(Proxies);
                        command.Options.Add(ProxySettings);
                        command.Options.Add(Region);
                        command.Options.Add(UserMetadata);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Browserbase.SessionsCreateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Browserbase.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var projectId = CliRuntime.WasSpecified(parseResult, ProjectId) ? parseResult.GetValue(ProjectId) : (__requestBase is { } __ProjectIdBaseValue ? __ProjectIdBaseValue.ProjectId : default);
                        var extensionId = CliRuntime.WasSpecified(parseResult, ExtensionId) ? parseResult.GetValue(ExtensionId) : (__requestBase is { } __ExtensionIdBaseValue ? __ExtensionIdBaseValue.ExtensionId : default);
                        var browserSettings = CliRuntime.WasSpecified(parseResult, BrowserSettings) ? parseResult.GetValue(BrowserSettings) : (__requestBase is { } __BrowserSettingsBaseValue ? __BrowserSettingsBaseValue.BrowserSettings : default);
                        var timeout = CliRuntime.WasSpecified(parseResult, Timeout) ? parseResult.GetValue(Timeout) : (__requestBase is { } __TimeoutBaseValue ? __TimeoutBaseValue.Timeout : default);
                        var keepAlive = CliRuntime.WasSpecified(parseResult, KeepAlive) ? parseResult.GetValue(KeepAlive) : (__requestBase is { } __KeepAliveBaseValue ? __KeepAliveBaseValue.KeepAlive : default);
                        var proxies = CliRuntime.WasSpecified(parseResult, Proxies) ? parseResult.GetValue(Proxies) : (__requestBase is { } __ProxiesBaseValue ? __ProxiesBaseValue.Proxies : default);
                        var proxySettings = CliRuntime.WasSpecified(parseResult, ProxySettings) ? parseResult.GetValue(ProxySettings) : (__requestBase is { } __ProxySettingsBaseValue ? __ProxySettingsBaseValue.ProxySettings : default);
                        var region = CliRuntime.WasSpecified(parseResult, Region) ? parseResult.GetValue(Region) : (__requestBase is { } __RegionBaseValue ? __RegionBaseValue.Region : default);
                        var userMetadata = CliRuntime.WasSpecified(parseResult, UserMetadata) ? parseResult.GetValue(UserMetadata) : (__requestBase is { } __UserMetadataBaseValue ? __UserMetadataBaseValue.UserMetadata : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SessionsCreateAsync(
                                    projectId: projectId,
                                    extensionId: extensionId,
                                    browserSettings: browserSettings,
                                    timeout: timeout,
                                    keepAlive: keepAlive,
                                    proxies: proxies,
                                    proxySettings: proxySettings,
                                    region: region,
                                    userMetadata: userMetadata,
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