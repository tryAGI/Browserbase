# Microsoft.Extensions.AI Integration

Browserbase provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to perform web searches, fetch pages, and manage browser sessions.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchWebTool()` | `SearchWeb` | Performs a web search and returns structured results. |
| `AsFetchPageTool()` | `FetchPage` | Fetches a web page and returns its content. |
| `AsCreateSessionTool()` | `CreateBrowserSession` | Creates a new browser session with WebSocket connect URL. |
| `AsListSessionsTool()` | `ListBrowserSessions` | Lists browser sessions with statuses. |

## Usage

```csharp
using Browserbase;
using Microsoft.Extensions.AI;

var browserbase = new BrowserbaseClient(apiKey);

// Create tools
var tools = new[]
{
    browserbase.AsSearchWebTool(),
    browserbase.AsFetchPageTool(),
    browserbase.AsCreateSessionTool(),
    browserbase.AsListSessionsTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "Search the web for 'latest AI news' and fetch the first result",
    new ChatOptions { Tools = tools });
```

## Tool Details

### SearchWeb

Performs a web search and returns structured results with titles, URLs, authors, and dates.

```csharp
var tool = browserbase.AsSearchWebTool(numResults: 5);
```

### FetchPage

Fetches a web page and returns the content, HTTP status code, and content type.
Automatically follows redirects.

### CreateBrowserSession

Creates a new cloud browser session. Returns the session ID, status,
and WebSocket connect URL for remote browser automation.

### ListBrowserSessions

Lists all browser sessions with their IDs, statuses, and creation/end dates.
