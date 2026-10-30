
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPolicyBlockedCategorie
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
    public static class NavigationPolicyBlockedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPolicyBlockedCategorie value)
        {
            return value switch
            {
                NavigationPolicyBlockedCategorie.Adult => "adult",
                NavigationPolicyBlockedCategorie.AiTools => "ai-tools",
                NavigationPolicyBlockedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPolicyBlockedCategorie.Business => "business",
                NavigationPolicyBlockedCategorie.ChildAbuse => "child-abuse",
                NavigationPolicyBlockedCategorie.Communication => "communication",
                NavigationPolicyBlockedCategorie.Dating => "dating",
                NavigationPolicyBlockedCategorie.Drugs => "drugs",
                NavigationPolicyBlockedCategorie.Education => "education",
                NavigationPolicyBlockedCategorie.Entertainment => "entertainment",
                NavigationPolicyBlockedCategorie.Finance => "finance",
                NavigationPolicyBlockedCategorie.Gambling => "gambling",
                NavigationPolicyBlockedCategorie.Games => "games",
                NavigationPolicyBlockedCategorie.GovernmentMilitary => "government-military",
                NavigationPolicyBlockedCategorie.Hacking => "hacking",
                NavigationPolicyBlockedCategorie.Hate => "hate",
                NavigationPolicyBlockedCategorie.Health => "health",
                NavigationPolicyBlockedCategorie.IllegalActivity => "illegal-activity",
                NavigationPolicyBlockedCategorie.Infrastructure => "infrastructure",
                NavigationPolicyBlockedCategorie.Kids => "kids",
                NavigationPolicyBlockedCategorie.Lifestyle => "lifestyle",
                NavigationPolicyBlockedCategorie.Malware => "malware",
                NavigationPolicyBlockedCategorie.NewlyRegistered => "newly-registered",
                NavigationPolicyBlockedCategorie.News => "news",
                NavigationPolicyBlockedCategorie.ParkedInactive => "parked-inactive",
                NavigationPolicyBlockedCategorie.PhishingScams => "phishing-scams",
                NavigationPolicyBlockedCategorie.Piracy => "piracy",
                NavigationPolicyBlockedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPolicyBlockedCategorie.SearchPortal => "search-portal",
                NavigationPolicyBlockedCategorie.SelfHarm => "self-harm",
                NavigationPolicyBlockedCategorie.Shopping => "shopping",
                NavigationPolicyBlockedCategorie.SocialMedia => "social-media",
                NavigationPolicyBlockedCategorie.SocietyCulture => "society-culture",
                NavigationPolicyBlockedCategorie.Sports => "sports",
                NavigationPolicyBlockedCategorie.Technology => "technology",
                NavigationPolicyBlockedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPolicyBlockedCategorie.Travel => "travel",
                NavigationPolicyBlockedCategorie.UrlShortener => "url-shortener",
                NavigationPolicyBlockedCategorie.Violence => "violence",
                NavigationPolicyBlockedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPolicyBlockedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPolicyBlockedCategorie.Adult,
                "ai-tools" => NavigationPolicyBlockedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPolicyBlockedCategorie.AlcoholTobacco,
                "business" => NavigationPolicyBlockedCategorie.Business,
                "child-abuse" => NavigationPolicyBlockedCategorie.ChildAbuse,
                "communication" => NavigationPolicyBlockedCategorie.Communication,
                "dating" => NavigationPolicyBlockedCategorie.Dating,
                "drugs" => NavigationPolicyBlockedCategorie.Drugs,
                "education" => NavigationPolicyBlockedCategorie.Education,
                "entertainment" => NavigationPolicyBlockedCategorie.Entertainment,
                "finance" => NavigationPolicyBlockedCategorie.Finance,
                "gambling" => NavigationPolicyBlockedCategorie.Gambling,
                "games" => NavigationPolicyBlockedCategorie.Games,
                "government-military" => NavigationPolicyBlockedCategorie.GovernmentMilitary,
                "hacking" => NavigationPolicyBlockedCategorie.Hacking,
                "hate" => NavigationPolicyBlockedCategorie.Hate,
                "health" => NavigationPolicyBlockedCategorie.Health,
                "illegal-activity" => NavigationPolicyBlockedCategorie.IllegalActivity,
                "infrastructure" => NavigationPolicyBlockedCategorie.Infrastructure,
                "kids" => NavigationPolicyBlockedCategorie.Kids,
                "lifestyle" => NavigationPolicyBlockedCategorie.Lifestyle,
                "malware" => NavigationPolicyBlockedCategorie.Malware,
                "newly-registered" => NavigationPolicyBlockedCategorie.NewlyRegistered,
                "news" => NavigationPolicyBlockedCategorie.News,
                "parked-inactive" => NavigationPolicyBlockedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPolicyBlockedCategorie.PhishingScams,
                "piracy" => NavigationPolicyBlockedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPolicyBlockedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPolicyBlockedCategorie.SearchPortal,
                "self-harm" => NavigationPolicyBlockedCategorie.SelfHarm,
                "shopping" => NavigationPolicyBlockedCategorie.Shopping,
                "social-media" => NavigationPolicyBlockedCategorie.SocialMedia,
                "society-culture" => NavigationPolicyBlockedCategorie.SocietyCulture,
                "sports" => NavigationPolicyBlockedCategorie.Sports,
                "technology" => NavigationPolicyBlockedCategorie.Technology,
                "terrorism-extremism" => NavigationPolicyBlockedCategorie.TerrorismExtremism,
                "travel" => NavigationPolicyBlockedCategorie.Travel,
                "url-shortener" => NavigationPolicyBlockedCategorie.UrlShortener,
                "violence" => NavigationPolicyBlockedCategorie.Violence,
                "weapons" => NavigationPolicyBlockedCategorie.Weapons,
                _ => null,
            };
        }
    }
}