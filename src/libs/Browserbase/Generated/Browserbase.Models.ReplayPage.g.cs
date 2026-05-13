
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplayPage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayPage" /> class.
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="url"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplayPage(
            string pageId,
            string url,
            double startTimeMs,
            double endTimeMs)
        {
            this.PageId = pageId ?? throw new global::System.ArgumentNullException(nameof(pageId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayPage" /> class.
        /// </summary>
        public ReplayPage()
        {
        }

    }
}