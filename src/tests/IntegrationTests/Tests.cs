namespace Browserbase.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BrowserbaseClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BROWSERBASE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BROWSERBASE_API_KEY environment variable is not found.");

        var client = new BrowserbaseClient(apiKey);
        
        return client;
    }
}
