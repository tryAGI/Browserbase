
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPolicyAllowedCategorie
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
    public static class NavigationPolicyAllowedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPolicyAllowedCategorie value)
        {
            return value switch
            {
                NavigationPolicyAllowedCategorie.Adult => "adult",
                NavigationPolicyAllowedCategorie.AiTools => "ai-tools",
                NavigationPolicyAllowedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPolicyAllowedCategorie.Business => "business",
                NavigationPolicyAllowedCategorie.ChildAbuse => "child-abuse",
                NavigationPolicyAllowedCategorie.Communication => "communication",
                NavigationPolicyAllowedCategorie.Dating => "dating",
                NavigationPolicyAllowedCategorie.Drugs => "drugs",
                NavigationPolicyAllowedCategorie.Education => "education",
                NavigationPolicyAllowedCategorie.Entertainment => "entertainment",
                NavigationPolicyAllowedCategorie.Finance => "finance",
                NavigationPolicyAllowedCategorie.Gambling => "gambling",
                NavigationPolicyAllowedCategorie.Games => "games",
                NavigationPolicyAllowedCategorie.GovernmentMilitary => "government-military",
                NavigationPolicyAllowedCategorie.Hacking => "hacking",
                NavigationPolicyAllowedCategorie.Hate => "hate",
                NavigationPolicyAllowedCategorie.Health => "health",
                NavigationPolicyAllowedCategorie.IllegalActivity => "illegal-activity",
                NavigationPolicyAllowedCategorie.Infrastructure => "infrastructure",
                NavigationPolicyAllowedCategorie.Kids => "kids",
                NavigationPolicyAllowedCategorie.Lifestyle => "lifestyle",
                NavigationPolicyAllowedCategorie.Malware => "malware",
                NavigationPolicyAllowedCategorie.NewlyRegistered => "newly-registered",
                NavigationPolicyAllowedCategorie.News => "news",
                NavigationPolicyAllowedCategorie.ParkedInactive => "parked-inactive",
                NavigationPolicyAllowedCategorie.PhishingScams => "phishing-scams",
                NavigationPolicyAllowedCategorie.Piracy => "piracy",
                NavigationPolicyAllowedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPolicyAllowedCategorie.SearchPortal => "search-portal",
                NavigationPolicyAllowedCategorie.SelfHarm => "self-harm",
                NavigationPolicyAllowedCategorie.Shopping => "shopping",
                NavigationPolicyAllowedCategorie.SocialMedia => "social-media",
                NavigationPolicyAllowedCategorie.SocietyCulture => "society-culture",
                NavigationPolicyAllowedCategorie.Sports => "sports",
                NavigationPolicyAllowedCategorie.Technology => "technology",
                NavigationPolicyAllowedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPolicyAllowedCategorie.Travel => "travel",
                NavigationPolicyAllowedCategorie.UrlShortener => "url-shortener",
                NavigationPolicyAllowedCategorie.Violence => "violence",
                NavigationPolicyAllowedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPolicyAllowedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPolicyAllowedCategorie.Adult,
                "ai-tools" => NavigationPolicyAllowedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPolicyAllowedCategorie.AlcoholTobacco,
                "business" => NavigationPolicyAllowedCategorie.Business,
                "child-abuse" => NavigationPolicyAllowedCategorie.ChildAbuse,
                "communication" => NavigationPolicyAllowedCategorie.Communication,
                "dating" => NavigationPolicyAllowedCategorie.Dating,
                "drugs" => NavigationPolicyAllowedCategorie.Drugs,
                "education" => NavigationPolicyAllowedCategorie.Education,
                "entertainment" => NavigationPolicyAllowedCategorie.Entertainment,
                "finance" => NavigationPolicyAllowedCategorie.Finance,
                "gambling" => NavigationPolicyAllowedCategorie.Gambling,
                "games" => NavigationPolicyAllowedCategorie.Games,
                "government-military" => NavigationPolicyAllowedCategorie.GovernmentMilitary,
                "hacking" => NavigationPolicyAllowedCategorie.Hacking,
                "hate" => NavigationPolicyAllowedCategorie.Hate,
                "health" => NavigationPolicyAllowedCategorie.Health,
                "illegal-activity" => NavigationPolicyAllowedCategorie.IllegalActivity,
                "infrastructure" => NavigationPolicyAllowedCategorie.Infrastructure,
                "kids" => NavigationPolicyAllowedCategorie.Kids,
                "lifestyle" => NavigationPolicyAllowedCategorie.Lifestyle,
                "malware" => NavigationPolicyAllowedCategorie.Malware,
                "newly-registered" => NavigationPolicyAllowedCategorie.NewlyRegistered,
                "news" => NavigationPolicyAllowedCategorie.News,
                "parked-inactive" => NavigationPolicyAllowedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPolicyAllowedCategorie.PhishingScams,
                "piracy" => NavigationPolicyAllowedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPolicyAllowedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPolicyAllowedCategorie.SearchPortal,
                "self-harm" => NavigationPolicyAllowedCategorie.SelfHarm,
                "shopping" => NavigationPolicyAllowedCategorie.Shopping,
                "social-media" => NavigationPolicyAllowedCategorie.SocialMedia,
                "society-culture" => NavigationPolicyAllowedCategorie.SocietyCulture,
                "sports" => NavigationPolicyAllowedCategorie.Sports,
                "technology" => NavigationPolicyAllowedCategorie.Technology,
                "terrorism-extremism" => NavigationPolicyAllowedCategorie.TerrorismExtremism,
                "travel" => NavigationPolicyAllowedCategorie.Travel,
                "url-shortener" => NavigationPolicyAllowedCategorie.UrlShortener,
                "violence" => NavigationPolicyAllowedCategorie.Violence,
                "weapons" => NavigationPolicyAllowedCategorie.Weapons,
                _ => null,
            };
        }
    }
}