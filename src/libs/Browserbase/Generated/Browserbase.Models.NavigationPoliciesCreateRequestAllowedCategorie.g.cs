
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPoliciesCreateRequestAllowedCategorie
    {
        /// <summary>
        ///
        /// </summary>
        Adult,
        /// <summary>
        ///
        /// </summary>
        AiTools,
        /// <summary>
        ///
        /// </summary>
        AlcoholTobacco,
        /// <summary>
        ///
        /// </summary>
        Business,
        /// <summary>
        ///
        /// </summary>
        ChildAbuse,
        /// <summary>
        ///
        /// </summary>
        Communication,
        /// <summary>
        ///
        /// </summary>
        Dating,
        /// <summary>
        ///
        /// </summary>
        Drugs,
        /// <summary>
        ///
        /// </summary>
        Education,
        /// <summary>
        ///
        /// </summary>
        Entertainment,
        /// <summary>
        ///
        /// </summary>
        Finance,
        /// <summary>
        ///
        /// </summary>
        Gambling,
        /// <summary>
        ///
        /// </summary>
        Games,
        /// <summary>
        ///
        /// </summary>
        GovernmentMilitary,
        /// <summary>
        ///
        /// </summary>
        Hacking,
        /// <summary>
        ///
        /// </summary>
        Hate,
        /// <summary>
        ///
        /// </summary>
        Health,
        /// <summary>
        ///
        /// </summary>
        IllegalActivity,
        /// <summary>
        ///
        /// </summary>
        Infrastructure,
        /// <summary>
        ///
        /// </summary>
        Kids,
        /// <summary>
        ///
        /// </summary>
        Lifestyle,
        /// <summary>
        ///
        /// </summary>
        Malware,
        /// <summary>
        ///
        /// </summary>
        NewlyRegistered,
        /// <summary>
        ///
        /// </summary>
        News,
        /// <summary>
        ///
        /// </summary>
        ParkedInactive,
        /// <summary>
        ///
        /// </summary>
        PhishingScams,
        /// <summary>
        ///
        /// </summary>
        Piracy,
        /// <summary>
        ///
        /// </summary>
        ProxyAnonymizer,
        /// <summary>
        ///
        /// </summary>
        SearchPortal,
        /// <summary>
        ///
        /// </summary>
        SelfHarm,
        /// <summary>
        ///
        /// </summary>
        Shopping,
        /// <summary>
        ///
        /// </summary>
        SocialMedia,
        /// <summary>
        ///
        /// </summary>
        SocietyCulture,
        /// <summary>
        ///
        /// </summary>
        Sports,
        /// <summary>
        ///
        /// </summary>
        Technology,
        /// <summary>
        ///
        /// </summary>
        TerrorismExtremism,
        /// <summary>
        ///
        /// </summary>
        Travel,
        /// <summary>
        ///
        /// </summary>
        UrlShortener,
        /// <summary>
        ///
        /// </summary>
        Violence,
        /// <summary>
        ///
        /// </summary>
        Weapons,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NavigationPoliciesCreateRequestAllowedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesCreateRequestAllowedCategorie value)
        {
            return value switch
            {
                NavigationPoliciesCreateRequestAllowedCategorie.Adult => "adult",
                NavigationPoliciesCreateRequestAllowedCategorie.AiTools => "ai-tools",
                NavigationPoliciesCreateRequestAllowedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPoliciesCreateRequestAllowedCategorie.Business => "business",
                NavigationPoliciesCreateRequestAllowedCategorie.ChildAbuse => "child-abuse",
                NavigationPoliciesCreateRequestAllowedCategorie.Communication => "communication",
                NavigationPoliciesCreateRequestAllowedCategorie.Dating => "dating",
                NavigationPoliciesCreateRequestAllowedCategorie.Drugs => "drugs",
                NavigationPoliciesCreateRequestAllowedCategorie.Education => "education",
                NavigationPoliciesCreateRequestAllowedCategorie.Entertainment => "entertainment",
                NavigationPoliciesCreateRequestAllowedCategorie.Finance => "finance",
                NavigationPoliciesCreateRequestAllowedCategorie.Gambling => "gambling",
                NavigationPoliciesCreateRequestAllowedCategorie.Games => "games",
                NavigationPoliciesCreateRequestAllowedCategorie.GovernmentMilitary => "government-military",
                NavigationPoliciesCreateRequestAllowedCategorie.Hacking => "hacking",
                NavigationPoliciesCreateRequestAllowedCategorie.Hate => "hate",
                NavigationPoliciesCreateRequestAllowedCategorie.Health => "health",
                NavigationPoliciesCreateRequestAllowedCategorie.IllegalActivity => "illegal-activity",
                NavigationPoliciesCreateRequestAllowedCategorie.Infrastructure => "infrastructure",
                NavigationPoliciesCreateRequestAllowedCategorie.Kids => "kids",
                NavigationPoliciesCreateRequestAllowedCategorie.Lifestyle => "lifestyle",
                NavigationPoliciesCreateRequestAllowedCategorie.Malware => "malware",
                NavigationPoliciesCreateRequestAllowedCategorie.NewlyRegistered => "newly-registered",
                NavigationPoliciesCreateRequestAllowedCategorie.News => "news",
                NavigationPoliciesCreateRequestAllowedCategorie.ParkedInactive => "parked-inactive",
                NavigationPoliciesCreateRequestAllowedCategorie.PhishingScams => "phishing-scams",
                NavigationPoliciesCreateRequestAllowedCategorie.Piracy => "piracy",
                NavigationPoliciesCreateRequestAllowedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPoliciesCreateRequestAllowedCategorie.SearchPortal => "search-portal",
                NavigationPoliciesCreateRequestAllowedCategorie.SelfHarm => "self-harm",
                NavigationPoliciesCreateRequestAllowedCategorie.Shopping => "shopping",
                NavigationPoliciesCreateRequestAllowedCategorie.SocialMedia => "social-media",
                NavigationPoliciesCreateRequestAllowedCategorie.SocietyCulture => "society-culture",
                NavigationPoliciesCreateRequestAllowedCategorie.Sports => "sports",
                NavigationPoliciesCreateRequestAllowedCategorie.Technology => "technology",
                NavigationPoliciesCreateRequestAllowedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPoliciesCreateRequestAllowedCategorie.Travel => "travel",
                NavigationPoliciesCreateRequestAllowedCategorie.UrlShortener => "url-shortener",
                NavigationPoliciesCreateRequestAllowedCategorie.Violence => "violence",
                NavigationPoliciesCreateRequestAllowedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesCreateRequestAllowedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPoliciesCreateRequestAllowedCategorie.Adult,
                "ai-tools" => NavigationPoliciesCreateRequestAllowedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPoliciesCreateRequestAllowedCategorie.AlcoholTobacco,
                "business" => NavigationPoliciesCreateRequestAllowedCategorie.Business,
                "child-abuse" => NavigationPoliciesCreateRequestAllowedCategorie.ChildAbuse,
                "communication" => NavigationPoliciesCreateRequestAllowedCategorie.Communication,
                "dating" => NavigationPoliciesCreateRequestAllowedCategorie.Dating,
                "drugs" => NavigationPoliciesCreateRequestAllowedCategorie.Drugs,
                "education" => NavigationPoliciesCreateRequestAllowedCategorie.Education,
                "entertainment" => NavigationPoliciesCreateRequestAllowedCategorie.Entertainment,
                "finance" => NavigationPoliciesCreateRequestAllowedCategorie.Finance,
                "gambling" => NavigationPoliciesCreateRequestAllowedCategorie.Gambling,
                "games" => NavigationPoliciesCreateRequestAllowedCategorie.Games,
                "government-military" => NavigationPoliciesCreateRequestAllowedCategorie.GovernmentMilitary,
                "hacking" => NavigationPoliciesCreateRequestAllowedCategorie.Hacking,
                "hate" => NavigationPoliciesCreateRequestAllowedCategorie.Hate,
                "health" => NavigationPoliciesCreateRequestAllowedCategorie.Health,
                "illegal-activity" => NavigationPoliciesCreateRequestAllowedCategorie.IllegalActivity,
                "infrastructure" => NavigationPoliciesCreateRequestAllowedCategorie.Infrastructure,
                "kids" => NavigationPoliciesCreateRequestAllowedCategorie.Kids,
                "lifestyle" => NavigationPoliciesCreateRequestAllowedCategorie.Lifestyle,
                "malware" => NavigationPoliciesCreateRequestAllowedCategorie.Malware,
                "newly-registered" => NavigationPoliciesCreateRequestAllowedCategorie.NewlyRegistered,
                "news" => NavigationPoliciesCreateRequestAllowedCategorie.News,
                "parked-inactive" => NavigationPoliciesCreateRequestAllowedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPoliciesCreateRequestAllowedCategorie.PhishingScams,
                "piracy" => NavigationPoliciesCreateRequestAllowedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPoliciesCreateRequestAllowedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPoliciesCreateRequestAllowedCategorie.SearchPortal,
                "self-harm" => NavigationPoliciesCreateRequestAllowedCategorie.SelfHarm,
                "shopping" => NavigationPoliciesCreateRequestAllowedCategorie.Shopping,
                "social-media" => NavigationPoliciesCreateRequestAllowedCategorie.SocialMedia,
                "society-culture" => NavigationPoliciesCreateRequestAllowedCategorie.SocietyCulture,
                "sports" => NavigationPoliciesCreateRequestAllowedCategorie.Sports,
                "technology" => NavigationPoliciesCreateRequestAllowedCategorie.Technology,
                "terrorism-extremism" => NavigationPoliciesCreateRequestAllowedCategorie.TerrorismExtremism,
                "travel" => NavigationPoliciesCreateRequestAllowedCategorie.Travel,
                "url-shortener" => NavigationPoliciesCreateRequestAllowedCategorie.UrlShortener,
                "violence" => NavigationPoliciesCreateRequestAllowedCategorie.Violence,
                "weapons" => NavigationPoliciesCreateRequestAllowedCategorie.Weapons,
                _ => null,
            };
        }
    }
}