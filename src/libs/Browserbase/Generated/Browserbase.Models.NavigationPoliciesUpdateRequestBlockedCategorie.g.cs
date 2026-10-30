
#nullable enable

namespace Browserbase
{
    /// <summary>
    ///
    /// </summary>
    public enum NavigationPoliciesUpdateRequestBlockedCategorie
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
    public static class NavigationPoliciesUpdateRequestBlockedCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NavigationPoliciesUpdateRequestBlockedCategorie value)
        {
            return value switch
            {
                NavigationPoliciesUpdateRequestBlockedCategorie.Adult => "adult",
                NavigationPoliciesUpdateRequestBlockedCategorie.AiTools => "ai-tools",
                NavigationPoliciesUpdateRequestBlockedCategorie.AlcoholTobacco => "alcohol-tobacco",
                NavigationPoliciesUpdateRequestBlockedCategorie.Business => "business",
                NavigationPoliciesUpdateRequestBlockedCategorie.ChildAbuse => "child-abuse",
                NavigationPoliciesUpdateRequestBlockedCategorie.Communication => "communication",
                NavigationPoliciesUpdateRequestBlockedCategorie.Dating => "dating",
                NavigationPoliciesUpdateRequestBlockedCategorie.Drugs => "drugs",
                NavigationPoliciesUpdateRequestBlockedCategorie.Education => "education",
                NavigationPoliciesUpdateRequestBlockedCategorie.Entertainment => "entertainment",
                NavigationPoliciesUpdateRequestBlockedCategorie.Finance => "finance",
                NavigationPoliciesUpdateRequestBlockedCategorie.Gambling => "gambling",
                NavigationPoliciesUpdateRequestBlockedCategorie.Games => "games",
                NavigationPoliciesUpdateRequestBlockedCategorie.GovernmentMilitary => "government-military",
                NavigationPoliciesUpdateRequestBlockedCategorie.Hacking => "hacking",
                NavigationPoliciesUpdateRequestBlockedCategorie.Hate => "hate",
                NavigationPoliciesUpdateRequestBlockedCategorie.Health => "health",
                NavigationPoliciesUpdateRequestBlockedCategorie.IllegalActivity => "illegal-activity",
                NavigationPoliciesUpdateRequestBlockedCategorie.Infrastructure => "infrastructure",
                NavigationPoliciesUpdateRequestBlockedCategorie.Kids => "kids",
                NavigationPoliciesUpdateRequestBlockedCategorie.Lifestyle => "lifestyle",
                NavigationPoliciesUpdateRequestBlockedCategorie.Malware => "malware",
                NavigationPoliciesUpdateRequestBlockedCategorie.NewlyRegistered => "newly-registered",
                NavigationPoliciesUpdateRequestBlockedCategorie.News => "news",
                NavigationPoliciesUpdateRequestBlockedCategorie.ParkedInactive => "parked-inactive",
                NavigationPoliciesUpdateRequestBlockedCategorie.PhishingScams => "phishing-scams",
                NavigationPoliciesUpdateRequestBlockedCategorie.Piracy => "piracy",
                NavigationPoliciesUpdateRequestBlockedCategorie.ProxyAnonymizer => "proxy-anonymizer",
                NavigationPoliciesUpdateRequestBlockedCategorie.SearchPortal => "search-portal",
                NavigationPoliciesUpdateRequestBlockedCategorie.SelfHarm => "self-harm",
                NavigationPoliciesUpdateRequestBlockedCategorie.Shopping => "shopping",
                NavigationPoliciesUpdateRequestBlockedCategorie.SocialMedia => "social-media",
                NavigationPoliciesUpdateRequestBlockedCategorie.SocietyCulture => "society-culture",
                NavigationPoliciesUpdateRequestBlockedCategorie.Sports => "sports",
                NavigationPoliciesUpdateRequestBlockedCategorie.Technology => "technology",
                NavigationPoliciesUpdateRequestBlockedCategorie.TerrorismExtremism => "terrorism-extremism",
                NavigationPoliciesUpdateRequestBlockedCategorie.Travel => "travel",
                NavigationPoliciesUpdateRequestBlockedCategorie.UrlShortener => "url-shortener",
                NavigationPoliciesUpdateRequestBlockedCategorie.Violence => "violence",
                NavigationPoliciesUpdateRequestBlockedCategorie.Weapons => "weapons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NavigationPoliciesUpdateRequestBlockedCategorie? ToEnum(string value)
        {
            return value switch
            {
                "adult" => NavigationPoliciesUpdateRequestBlockedCategorie.Adult,
                "ai-tools" => NavigationPoliciesUpdateRequestBlockedCategorie.AiTools,
                "alcohol-tobacco" => NavigationPoliciesUpdateRequestBlockedCategorie.AlcoholTobacco,
                "business" => NavigationPoliciesUpdateRequestBlockedCategorie.Business,
                "child-abuse" => NavigationPoliciesUpdateRequestBlockedCategorie.ChildAbuse,
                "communication" => NavigationPoliciesUpdateRequestBlockedCategorie.Communication,
                "dating" => NavigationPoliciesUpdateRequestBlockedCategorie.Dating,
                "drugs" => NavigationPoliciesUpdateRequestBlockedCategorie.Drugs,
                "education" => NavigationPoliciesUpdateRequestBlockedCategorie.Education,
                "entertainment" => NavigationPoliciesUpdateRequestBlockedCategorie.Entertainment,
                "finance" => NavigationPoliciesUpdateRequestBlockedCategorie.Finance,
                "gambling" => NavigationPoliciesUpdateRequestBlockedCategorie.Gambling,
                "games" => NavigationPoliciesUpdateRequestBlockedCategorie.Games,
                "government-military" => NavigationPoliciesUpdateRequestBlockedCategorie.GovernmentMilitary,
                "hacking" => NavigationPoliciesUpdateRequestBlockedCategorie.Hacking,
                "hate" => NavigationPoliciesUpdateRequestBlockedCategorie.Hate,
                "health" => NavigationPoliciesUpdateRequestBlockedCategorie.Health,
                "illegal-activity" => NavigationPoliciesUpdateRequestBlockedCategorie.IllegalActivity,
                "infrastructure" => NavigationPoliciesUpdateRequestBlockedCategorie.Infrastructure,
                "kids" => NavigationPoliciesUpdateRequestBlockedCategorie.Kids,
                "lifestyle" => NavigationPoliciesUpdateRequestBlockedCategorie.Lifestyle,
                "malware" => NavigationPoliciesUpdateRequestBlockedCategorie.Malware,
                "newly-registered" => NavigationPoliciesUpdateRequestBlockedCategorie.NewlyRegistered,
                "news" => NavigationPoliciesUpdateRequestBlockedCategorie.News,
                "parked-inactive" => NavigationPoliciesUpdateRequestBlockedCategorie.ParkedInactive,
                "phishing-scams" => NavigationPoliciesUpdateRequestBlockedCategorie.PhishingScams,
                "piracy" => NavigationPoliciesUpdateRequestBlockedCategorie.Piracy,
                "proxy-anonymizer" => NavigationPoliciesUpdateRequestBlockedCategorie.ProxyAnonymizer,
                "search-portal" => NavigationPoliciesUpdateRequestBlockedCategorie.SearchPortal,
                "self-harm" => NavigationPoliciesUpdateRequestBlockedCategorie.SelfHarm,
                "shopping" => NavigationPoliciesUpdateRequestBlockedCategorie.Shopping,
                "social-media" => NavigationPoliciesUpdateRequestBlockedCategorie.SocialMedia,
                "society-culture" => NavigationPoliciesUpdateRequestBlockedCategorie.SocietyCulture,
                "sports" => NavigationPoliciesUpdateRequestBlockedCategorie.Sports,
                "technology" => NavigationPoliciesUpdateRequestBlockedCategorie.Technology,
                "terrorism-extremism" => NavigationPoliciesUpdateRequestBlockedCategorie.TerrorismExtremism,
                "travel" => NavigationPoliciesUpdateRequestBlockedCategorie.Travel,
                "url-shortener" => NavigationPoliciesUpdateRequestBlockedCategorie.UrlShortener,
                "violence" => NavigationPoliciesUpdateRequestBlockedCategorie.Violence,
                "weapons" => NavigationPoliciesUpdateRequestBlockedCategorie.Weapons,
                _ => null,
            };
        }
    }
}