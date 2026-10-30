
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPoliciesCreateRequestBlockedCategorie
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
    public static class NavigationPoliciesCreateRequestBlockedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesCreateRequestBlockedCategorie value)
        {
            return value switch
            {
                NavigationPoliciesCreateRequestBlockedCategorie.Adult => "adult",
                NavigationPoliciesCreateRequestBlockedCategorie.AiTools => "ai-tools",
                NavigationPoliciesCreateRequestBlockedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPoliciesCreateRequestBlockedCategorie.Business => "business",
                NavigationPoliciesCreateRequestBlockedCategorie.ChildAbuse => "child-abuse",
                NavigationPoliciesCreateRequestBlockedCategorie.Communication => "communication",
                NavigationPoliciesCreateRequestBlockedCategorie.Dating => "dating",
                NavigationPoliciesCreateRequestBlockedCategorie.Drugs => "drugs",
                NavigationPoliciesCreateRequestBlockedCategorie.Education => "education",
                NavigationPoliciesCreateRequestBlockedCategorie.Entertainment => "entertainment",
                NavigationPoliciesCreateRequestBlockedCategorie.Finance => "finance",
                NavigationPoliciesCreateRequestBlockedCategorie.Gambling => "gambling",
                NavigationPoliciesCreateRequestBlockedCategorie.Games => "games",
                NavigationPoliciesCreateRequestBlockedCategorie.GovernmentMilitary => "government-military",
                NavigationPoliciesCreateRequestBlockedCategorie.Hacking => "hacking",
                NavigationPoliciesCreateRequestBlockedCategorie.Hate => "hate",
                NavigationPoliciesCreateRequestBlockedCategorie.Health => "health",
                NavigationPoliciesCreateRequestBlockedCategorie.IllegalActivity => "illegal-activity",
                NavigationPoliciesCreateRequestBlockedCategorie.Infrastructure => "infrastructure",
                NavigationPoliciesCreateRequestBlockedCategorie.Kids => "kids",
                NavigationPoliciesCreateRequestBlockedCategorie.Lifestyle => "lifestyle",
                NavigationPoliciesCreateRequestBlockedCategorie.Malware => "malware",
                NavigationPoliciesCreateRequestBlockedCategorie.NewlyRegistered => "newly-registered",
                NavigationPoliciesCreateRequestBlockedCategorie.News => "news",
                NavigationPoliciesCreateRequestBlockedCategorie.ParkedInactive => "parked-inactive",
                NavigationPoliciesCreateRequestBlockedCategorie.PhishingScams => "phishing-scams",
                NavigationPoliciesCreateRequestBlockedCategorie.Piracy => "piracy",
                NavigationPoliciesCreateRequestBlockedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPoliciesCreateRequestBlockedCategorie.SearchPortal => "search-portal",
                NavigationPoliciesCreateRequestBlockedCategorie.SelfHarm => "self-harm",
                NavigationPoliciesCreateRequestBlockedCategorie.Shopping => "shopping",
                NavigationPoliciesCreateRequestBlockedCategorie.SocialMedia => "social-media",
                NavigationPoliciesCreateRequestBlockedCategorie.SocietyCulture => "society-culture",
                NavigationPoliciesCreateRequestBlockedCategorie.Sports => "sports",
                NavigationPoliciesCreateRequestBlockedCategorie.Technology => "technology",
                NavigationPoliciesCreateRequestBlockedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPoliciesCreateRequestBlockedCategorie.Travel => "travel",
                NavigationPoliciesCreateRequestBlockedCategorie.UrlShortener => "url-shortener",
                NavigationPoliciesCreateRequestBlockedCategorie.Violence => "violence",
                NavigationPoliciesCreateRequestBlockedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesCreateRequestBlockedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPoliciesCreateRequestBlockedCategorie.Adult,
                "ai-tools" => NavigationPoliciesCreateRequestBlockedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPoliciesCreateRequestBlockedCategorie.AlcoholTobacco,
                "business" => NavigationPoliciesCreateRequestBlockedCategorie.Business,
                "child-abuse" => NavigationPoliciesCreateRequestBlockedCategorie.ChildAbuse,
                "communication" => NavigationPoliciesCreateRequestBlockedCategorie.Communication,
                "dating" => NavigationPoliciesCreateRequestBlockedCategorie.Dating,
                "drugs" => NavigationPoliciesCreateRequestBlockedCategorie.Drugs,
                "education" => NavigationPoliciesCreateRequestBlockedCategorie.Education,
                "entertainment" => NavigationPoliciesCreateRequestBlockedCategorie.Entertainment,
                "finance" => NavigationPoliciesCreateRequestBlockedCategorie.Finance,
                "gambling" => NavigationPoliciesCreateRequestBlockedCategorie.Gambling,
                "games" => NavigationPoliciesCreateRequestBlockedCategorie.Games,
                "government-military" => NavigationPoliciesCreateRequestBlockedCategorie.GovernmentMilitary,
                "hacking" => NavigationPoliciesCreateRequestBlockedCategorie.Hacking,
                "hate" => NavigationPoliciesCreateRequestBlockedCategorie.Hate,
                "health" => NavigationPoliciesCreateRequestBlockedCategorie.Health,
                "illegal-activity" => NavigationPoliciesCreateRequestBlockedCategorie.IllegalActivity,
                "infrastructure" => NavigationPoliciesCreateRequestBlockedCategorie.Infrastructure,
                "kids" => NavigationPoliciesCreateRequestBlockedCategorie.Kids,
                "lifestyle" => NavigationPoliciesCreateRequestBlockedCategorie.Lifestyle,
                "malware" => NavigationPoliciesCreateRequestBlockedCategorie.Malware,
                "newly-registered" => NavigationPoliciesCreateRequestBlockedCategorie.NewlyRegistered,
                "news" => NavigationPoliciesCreateRequestBlockedCategorie.News,
                "parked-inactive" => NavigationPoliciesCreateRequestBlockedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPoliciesCreateRequestBlockedCategorie.PhishingScams,
                "piracy" => NavigationPoliciesCreateRequestBlockedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPoliciesCreateRequestBlockedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPoliciesCreateRequestBlockedCategorie.SearchPortal,
                "self-harm" => NavigationPoliciesCreateRequestBlockedCategorie.SelfHarm,
                "shopping" => NavigationPoliciesCreateRequestBlockedCategorie.Shopping,
                "social-media" => NavigationPoliciesCreateRequestBlockedCategorie.SocialMedia,
                "society-culture" => NavigationPoliciesCreateRequestBlockedCategorie.SocietyCulture,
                "sports" => NavigationPoliciesCreateRequestBlockedCategorie.Sports,
                "technology" => NavigationPoliciesCreateRequestBlockedCategorie.Technology,
                "terrorism-extremism" => NavigationPoliciesCreateRequestBlockedCategorie.TerrorismExtremism,
                "travel" => NavigationPoliciesCreateRequestBlockedCategorie.Travel,
                "url-shortener" => NavigationPoliciesCreateRequestBlockedCategorie.UrlShortener,
                "violence" => NavigationPoliciesCreateRequestBlockedCategorie.Violence,
                "weapons" => NavigationPoliciesCreateRequestBlockedCategorie.Weapons,
                _ => null,
            };
        }
    }
}