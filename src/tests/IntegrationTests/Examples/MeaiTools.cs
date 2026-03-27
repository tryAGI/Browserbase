/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Browserbase.IntegrationTests;

public partial class Tests
{
    //// Browserbase provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// web search, page fetching, and browser session management.

    [TestMethod]
    public async Task Meai_AsSearchWebTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that performs web searches:
        var tool = client.AsSearchWebTool(numResults: 5);

        tool.Name.Should().Be("SearchWeb");
        tool.Description.Should().Contain("search");

        //// The tool accepts a `query` parameter and returns structured results.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments { ["query"] = "Browserbase cloud browser" },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"SearchWeb result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsFetchPageTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that fetches web page content:
        var tool = client.AsFetchPageTool();

        tool.Name.Should().Be("FetchPage");
        tool.Description.Should().Contain("page");
    }

    [TestMethod]
    public async Task Meai_AsCreateSessionTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that starts a new browser session:
        var tool = client.AsCreateSessionTool();

        tool.Name.Should().Be("CreateBrowserSession");
        tool.Description.Should().Contain("session");
    }

    [TestMethod]
    public async Task Meai_AsListSessionsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists browser sessions:
        var tool = client.AsListSessionsTool();

        tool.Name.Should().Be("ListBrowserSessions");
        tool.Description.Should().Contain("session");

        //// The tool returns a JSON array of session objects.
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListSessions result: {result}");
    }
}
