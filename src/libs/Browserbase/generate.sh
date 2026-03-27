dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.browserbase.com/reference/api/openapi.v1.yaml

# Convert apiKey auth (X-BB-API-Key header) to http/bearer for AutoSDK
yq -i '
  .components.securitySchemes.BrowserbaseAuth = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"BrowserbaseAuth": []}]
' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Browserbase \
  --clientClassName BrowserbaseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
