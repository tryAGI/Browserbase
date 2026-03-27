# CLAUDE.md — Browserbase SDK

## Overview

Auto-generated C# SDK for [Browserbase](https://www.browserbase.com/) — cloud browser infrastructure for AI agents with browser sessions, contexts, extensions, functions, web search, and project management.
OpenAPI spec from `https://docs.browserbase.com/reference/api/openapi.v1.yaml`.

## Build & Test

```bash
dotnet build Browserbase.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (originally X-BB-API-Key header, converted for AutoSDK):

```csharp
var client = new BrowserbaseClient(apiKey); // BROWSERBASE_API_KEY env var
```

## Key Files

- `src/libs/Browserbase/openapi.yaml` — OpenAPI spec (downloaded from Browserbase docs)
- `src/libs/Browserbase/generate.sh` — Downloads spec, converts apiKey to http/bearer, runs autosdk
- `src/libs/Browserbase/Generated/` — **Never edit** — auto-generated code (~280 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- Browserbase uses `X-BB-API-Key` header auth natively
- `generate.sh` replaces `apiKey` security scheme with `http/bearer` via `yq` and adds top-level `security` array
- Uses `--exclude-deprecated-operations` flag

## API Endpoints

All endpoints are on the root `BrowserbaseClient` (no sub-client pattern):
- `client.SessionsCreateAsync(...)` — Create a browser session
- `client.SessionsGetAsync(...)` — Get session details
- `client.SessionsListAsync(...)` — List sessions
- `client.SessionsUpdateAsync(...)` — Update session
- `client.SessionsGetRecordingAsync(...)` — Get session recording
- `client.SessionsGetLogsAsync(...)` — Get session logs
- `client.SessionsGetDebugAsync(...)` — Get session debug info
- `client.SessionsGetDownloadsAsync(...)` — Get session downloads
- `client.SessionsUploadFileAsync(...)` — Upload file to session
- `client.ContextsCreateAsync(...)` — Create a persistent browser context
- `client.ContextsGetAsync(...)` — Get context details
- `client.ContextsUpdateAsync(...)` — Update context
- `client.ContextsDeleteAsync(...)` — Delete context
- `client.ExtensionsUploadAsync(...)` — Upload browser extension
- `client.ExtensionsGetAsync(...)` — Get extension details
- `client.ExtensionsDeleteAsync(...)` — Delete extension
- `client.FunctionsListAsync(...)` — List functions
- `client.FunctionsInvokeAsync(...)` — Invoke a function
- `client.SearchWebAsync(...)` — Web search
- `client.ProjectsListAsync(...)` — List projects
- `client.ProjectsUsageAsync(...)` — Get project usage

## MEAI

No MEAI interface implemented — Browserbase is a cloud browser platform with no matching MEAI interface.
