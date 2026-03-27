# Authentication

The Browserbase API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [browserbase.com](https://www.browserbase.com/)
2. Navigate to your dashboard settings
3. Create a new API key

## Client Initialization

```csharp
using Browserbase;

var client = new BrowserbaseClient(
    apiKey: Environment.GetEnvironmentVariable("BROWSERBASE_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export BROWSERBASE_API_KEY=your-api-key-here
```
