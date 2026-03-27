using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Browserbase;

/// <summary>
/// Extensions for using BrowserbaseClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class BrowserbaseToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that performs a web search via Browserbase.
    /// </summary>
    /// <param name="client">The Browserbase client.</param>
    /// <param name="numResults">Number of results to return (1-25, default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchWebTool(
        this BrowserbaseClient client,
        int numResults = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.SearchWebAsync(
                    request: new SearchWebRequest
                    {
                        Query = query,
                        NumResults = numResults,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Results.Select(r => new
                {
                    title = r.Title,
                    url = r.Url,
                    author = r.Author,
                    published_date = r.PublishedDate,
                }));
            },
            name: "SearchWeb",
            description: "Performs a web search via Browserbase and returns structured results with titles, URLs, authors, and dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that fetches a web page and returns its content.
    /// </summary>
    /// <param name="client">The Browserbase client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsFetchPageTool(this BrowserbaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string url, CancellationToken cancellationToken) =>
            {
                var response = await client.FetchCreateAsync(
                    request: new FetchCreateRequest
                    {
                        Url = url,
                        AllowRedirects = true,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    status_code = response.StatusCode,
                    content_type = response.ContentType,
                    content = response.Content,
                });
            },
            name: "FetchPage",
            description: "Fetches a web page via Browserbase and returns its content, status code, and content type. Follows redirects automatically.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new browser session.
    /// </summary>
    /// <param name="client">The Browserbase client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateSessionTool(this BrowserbaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.SessionsCreateAsync(
                    request: new SessionsCreateRequest(),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Value1?.Id,
                    status = response.Value1?.Status.ToString(),
                    created_at = response.Value1?.CreatedAt,
                    connect_url = response.Value2?.ConnectUrl,
                });
            },
            name: "CreateBrowserSession",
            description: "Creates a new Browserbase browser session. Returns the session ID, status, and WebSocket connect URL for remote browser control.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists browser sessions.
    /// </summary>
    /// <param name="client">The Browserbase client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListSessionsTool(this BrowserbaseClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var sessions = await client.SessionsListAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(sessions.Select(s => new
                {
                    id = s.Id,
                    status = s.Status.ToString(),
                    created_at = s.CreatedAt,
                    ended_at = s.EndedAt,
                }));
            },
            name: "ListBrowserSessions",
            description: "Lists Browserbase browser sessions. Returns session IDs, statuses, and creation/end dates.");
    }
}
