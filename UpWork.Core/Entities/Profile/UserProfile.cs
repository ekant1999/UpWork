using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Profile
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string CountryCode { get; set; }
        public string TimeZone { get; set; }
        public string PreferredLanguage { get; set; }
        public bool ProfileComplete { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Social media links
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string PortfolioUrl { get; set; }

        // Navigation property
        public virtual ApplicationUser User { get; set; }

    }
}
