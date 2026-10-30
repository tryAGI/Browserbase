
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPoliciesUpdateRequestAllowedCategorie
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
    public static class NavigationPoliciesUpdateRequestAllowedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesUpdateRequestAllowedCategorie value)
        {
            return value switch
            {
                NavigationPoliciesUpdateRequestAllowedCategorie.Adult => "adult",
                NavigationPoliciesUpdateRequestAllowedCategorie.AiTools => "ai-tools",
                NavigationPoliciesUpdateRequestAllowedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPoliciesUpdateRequestAllowedCategorie.Business => "business",
                NavigationPoliciesUpdateRequestAllowedCategorie.ChildAbuse => "child-abuse",
                NavigationPoliciesUpdateRequestAllowedCategorie.Communication => "communication",
                NavigationPoliciesUpdateRequestAllowedCategorie.Dating => "dating",
                NavigationPoliciesUpdateRequestAllowedCategorie.Drugs => "drugs",
                NavigationPoliciesUpdateRequestAllowedCategorie.Education => "education",
                NavigationPoliciesUpdateRequestAllowedCategorie.Entertainment => "entertainment",
                NavigationPoliciesUpdateRequestAllowedCategorie.Finance => "finance",
                NavigationPoliciesUpdateRequestAllowedCategorie.Gambling => "gambling",
                NavigationPoliciesUpdateRequestAllowedCategorie.Games => "games",
                NavigationPoliciesUpdateRequestAllowedCategorie.GovernmentMilitary => "government-military",
                NavigationPoliciesUpdateRequestAllowedCategorie.Hacking => "hacking",
                NavigationPoliciesUpdateRequestAllowedCategorie.Hate => "hate",
                NavigationPoliciesUpdateRequestAllowedCategorie.Health => "health",
                NavigationPoliciesUpdateRequestAllowedCategorie.IllegalActivity => "illegal-activity",
                NavigationPoliciesUpdateRequestAllowedCategorie.Infrastructure => "infrastructure",
                NavigationPoliciesUpdateRequestAllowedCategorie.Kids => "kids",
                NavigationPoliciesUpdateRequestAllowedCategorie.Lifestyle => "lifestyle",
                NavigationPoliciesUpdateRequestAllowedCategorie.Malware => "malware",
                NavigationPoliciesUpdateRequestAllowedCategorie.NewlyRegistered => "newly-registered",
                NavigationPoliciesUpdateRequestAllowedCategorie.News => "news",
                NavigationPoliciesUpdateRequestAllowedCategorie.ParkedInactive => "parked-inactive",
                NavigationPoliciesUpdateRequestAllowedCategorie.PhishingScams => "phishing-scams",
                NavigationPoliciesUpdateRequestAllowedCategorie.Piracy => "piracy",
                NavigationPoliciesUpdateRequestAllowedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPoliciesUpdateRequestAllowedCategorie.SearchPortal => "search-portal",
                NavigationPoliciesUpdateRequestAllowedCategorie.SelfHarm => "self-harm",
                NavigationPoliciesUpdateRequestAllowedCategorie.Shopping => "shopping",
                NavigationPoliciesUpdateRequestAllowedCategorie.SocialMedia => "social-media",
                NavigationPoliciesUpdateRequestAllowedCategorie.SocietyCulture => "society-culture",
                NavigationPoliciesUpdateRequestAllowedCategorie.Sports => "sports",
                NavigationPoliciesUpdateRequestAllowedCategorie.Technology => "technology",
                NavigationPoliciesUpdateRequestAllowedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPoliciesUpdateRequestAllowedCategorie.Travel => "travel",
                NavigationPoliciesUpdateRequestAllowedCategorie.UrlShortener => "url-shortener",
                NavigationPoliciesUpdateRequestAllowedCategorie.Violence => "violence",
                NavigationPoliciesUpdateRequestAllowedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesUpdateRequestAllowedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPoliciesUpdateRequestAllowedCategorie.Adult,
                "ai-tools" => NavigationPoliciesUpdateRequestAllowedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPoliciesUpdateRequestAllowedCategorie.AlcoholTobacco,
                "business" => NavigationPoliciesUpdateRequestAllowedCategorie.Business,
                "child-abuse" => NavigationPoliciesUpdateRequestAllowedCategorie.ChildAbuse,
                "communication" => NavigationPoliciesUpdateRequestAllowedCategorie.Communication,
                "dating" => NavigationPoliciesUpdateRequestAllowedCategorie.Dating,
                "drugs" => NavigationPoliciesUpdateRequestAllowedCategorie.Drugs,
                "education" => NavigationPoliciesUpdateRequestAllowedCategorie.Education,
                "entertainment" => NavigationPoliciesUpdateRequestAllowedCategorie.Entertainment,
                "finance" => NavigationPoliciesUpdateRequestAllowedCategorie.Finance,
                "gambling" => NavigationPoliciesUpdateRequestAllowedCategorie.Gambling,
                "games" => NavigationPoliciesUpdateRequestAllowedCategorie.Games,
                "government-military" => NavigationPoliciesUpdateRequestAllowedCategorie.GovernmentMilitary,
                "hacking" => NavigationPoliciesUpdateRequestAllowedCategorie.Hacking,
                "hate" => NavigationPoliciesUpdateRequestAllowedCategorie.Hate,
                "health" => NavigationPoliciesUpdateRequestAllowedCategorie.Health,
                "illegal-activity" => NavigationPoliciesUpdateRequestAllowedCategorie.IllegalActivity,
                "infrastructure" => NavigationPoliciesUpdateRequestAllowedCategorie.Infrastructure,
                "kids" => NavigationPoliciesUpdateRequestAllowedCategorie.Kids,
                "lifestyle" => NavigationPoliciesUpdateRequestAllowedCategorie.Lifestyle,
                "malware" => NavigationPoliciesUpdateRequestAllowedCategorie.Malware,
                "newly-registered" => NavigationPoliciesUpdateRequestAllowedCategorie.NewlyRegistered,
                "news" => NavigationPoliciesUpdateRequestAllowedCategorie.News,
                "parked-inactive" => NavigationPoliciesUpdateRequestAllowedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPoliciesUpdateRequestAllowedCategorie.PhishingScams,
                "piracy" => NavigationPoliciesUpdateRequestAllowedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPoliciesUpdateRequestAllowedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPoliciesUpdateRequestAllowedCategorie.SearchPortal,
                "self-harm" => NavigationPoliciesUpdateRequestAllowedCategorie.SelfHarm,
                "shopping" => NavigationPoliciesUpdateRequestAllowedCategorie.Shopping,
                "social-media" => NavigationPoliciesUpdateRequestAllowedCategorie.SocialMedia,
                "society-culture" => NavigationPoliciesUpdateRequestAllowedCategorie.SocietyCulture,
                "sports" => NavigationPoliciesUpdateRequestAllowedCategorie.Sports,
                "technology" => NavigationPoliciesUpdateRequestAllowedCategorie.Technology,
                "terrorism-extremism" => NavigationPoliciesUpdateRequestAllowedCategorie.TerrorismExtremism,
                "travel" => NavigationPoliciesUpdateRequestAllowedCategorie.Travel,
                "url-shortener" => NavigationPoliciesUpdateRequestAllowedCategorie.UrlShortener,
                "violence" => NavigationPoliciesUpdateRequestAllowedCategorie.Violence,
                "weapons" => NavigationPoliciesUpdateRequestAllowedCategorie.Weapons,
                _ => null,
            };
        }
    }
}