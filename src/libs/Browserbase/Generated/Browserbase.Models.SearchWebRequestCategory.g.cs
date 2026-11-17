
#nullable enable

namespace Browserbase
{
    /// <summary>
    /// Focus the search on a category of content. Only the `exa` provider supports this filter.
    /// </summary>
    public enum SearchWebRequestCategory
    {
        /// <summary>
        ///
        /// </summary>
        Company,
        /// <summary>
        ///
        /// </summary>
        FinancialReport,
        /// <summary>
        ///
        /// </summary>
        News,
        /// <summary>
        ///
        /// </summary>
        People,
        /// <summary>
        ///
        /// </summary>
        PersonalSite,
        /// <summary>
        ///
        /// </summary>
        Publication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchWebRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchWebRequestCategory value)
        {
            return value switch
            {
                SearchWebRequestCategory.Company => "company",
                SearchWebRequestCategory.FinancialReport => "financial report",
                SearchWebRequestCategory.News => "news",
                SearchWebRequestCategory.People => "people",
                SearchWebRequestCategory.PersonalSite => "personal site",
                SearchWebRequestCategory.Publication => "publication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchWebRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "company" => SearchWebRequestCategory.Company,
                "financial report" => SearchWebRequestCategory.FinancialReport,
                "news" => SearchWebRequestCategory.News,
                "people" => SearchWebRequestCategory.People,
                "personal site" => SearchWebRequestCategory.PersonalSite,
                "publication" => SearchWebRequestCategory.Publication,
                _ => null,
            };
        }
    }
}