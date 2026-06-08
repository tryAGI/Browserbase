
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Supplementary proxy settings. Optional.
    /// </summary>
    public sealed partial class SessionsCreateRequestProxySettings
    {
        /// <summary>
        /// The TLS certificate IDs to trust. Optional.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caCertificates")]
        public global::System.Collections.Generic.IList<global::System.Guid>? CaCertificates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestProxySettings" /> class.
        /// </summary>
        /// <param name="caCertificates">
        /// The TLS certificate IDs to trust. Optional.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsCreateRequestProxySettings(
            global::System.Collections.Generic.IList<global::System.Guid>? caCertificates)
        {
            this.CaCertificates = caCertificates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestProxySettings" /> class.
        /// </summary>
        public SessionsCreateRequestProxySettings()
        {
        }

    }
}