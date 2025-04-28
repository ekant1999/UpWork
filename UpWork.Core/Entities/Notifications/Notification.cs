using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Notifications
{
    public class Notification
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string RedirectUrl { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual ApplicationUser User { get; set; }
    }
}
