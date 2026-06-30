#nullable enable

using System.CommandLine;

namespace Browserbase.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(AgentRunsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(AgentRunsListCommandApiCommand.Create());
                         command.Subcommands.Add(AgentRunsMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesGetCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesListCommandApiCommand.Create());
                         command.Subcommands.Add(CertificatesUploadCommandApiCommand.Create());
                         command.Subcommands.Add(ContextsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(ContextsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ContextsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ContextsUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(DownloadsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DownloadsGetCommandApiCommand.Create());
                         command.Subcommands.Add(DownloadsListCommandApiCommand.Create());
                         command.Subcommands.Add(ExtensionsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ExtensionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ExtensionsUploadCommandApiCommand.Create());
                         command.Subcommands.Add(FetchCreateCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionBuildsGetCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionBuildsGetLogsCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionBuildsListCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionVersionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionVersionsListInvocationsCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionsInvokeCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionsListCommandApiCommand.Create());
                         command.Subcommands.Add(FunctionsListVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(InvocationsGetCommandApiCommand.Create());
                         command.Subcommands.Add(InvocationsGetLogsCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsListCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsUsageCommandApiCommand.Create());
                         command.Subcommands.Add(SearchWebCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetDebugCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetLogsCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetRecordingCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetReplayCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetReplayPageCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsListCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsUploadFileCommandApiCommand.Create());
        return command;
    }
}