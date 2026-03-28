
#nullable enable

namespace Browserbase
{
    public sealed partial class BrowserbaseClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Browserbase.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-BB-API-Key",
                Value = apiKey,
            });
        }
    }
}