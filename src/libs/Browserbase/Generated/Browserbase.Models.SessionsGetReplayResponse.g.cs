
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsGetReplayResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Browserbase.ReplayPage> Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetReplayResponse" /> class.
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="pageCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsGetReplayResponse(
            global::System.Collections.Generic.IList<global::Browserbase.ReplayPage> pages,
            int pageCount)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.PageCount = pageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetReplayResponse" /> class.
        /// </summary>
        public SessionsGetReplayResponse()
        {
        }

    }
}