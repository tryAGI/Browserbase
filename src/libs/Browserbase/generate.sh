#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.browserbase.com/reference/api/openapi.v1.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.browserbase.com/reference/api/openapi.v1.yaml

# Auth: --security-scheme overrides the spec's X-BB-API-Key header auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Browserbase \
  --clientClassName BrowserbaseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Browserbase.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Browserbase.CLI \
  --sdk-project ../../libs/Browserbase/Browserbase.csproj \
  --targetFramework net10.0 \
  --namespace Browserbase \
  --clientClassName BrowserbaseClient \
  --package-id Browserbase.CLI \
  --tool-command-name browserbase \
  --user-secrets-id Browserbase.CLI \
  --api-key-env-var BROWSERBASE_API_KEY \
  --base-url-env-var BROWSERBASE_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
