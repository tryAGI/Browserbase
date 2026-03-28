#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.browserbase.com/reference/api/openapi.v1.yaml

# Auth: --security-scheme overrides the spec's X-BB-API-Key header auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Browserbase \
  --clientClassName BrowserbaseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
