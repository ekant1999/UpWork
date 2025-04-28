using Microsoft.AspNetCore.Identity;
using UpWork.Core.Entities.Communication;
using UpWork.Core.Entities.Jobs;
using UpWork.Core.Entities.Notifications;

namespace UpWork.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }

        // Security & Tracking
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastActive { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

        public virtual ClientUser ClientUser { get; set; } // 1-to-1 link (optional)
        public virtual FreelancerUser FreelancerUser { get; set; } // 1-to-1 link (optional)

        public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
        public virtual ICollection<ChatRoomUser> ChatRoomUsers { get; set; } = new List<ChatRoomUser>();
        public virtual ICollection<Message> MessagesSent { get; set; } = new List<Message>();
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public virtual ICollection<NotificationPreference> NotificationPreferences { get; set; } = new List<NotificationPreference>();
    }
}
