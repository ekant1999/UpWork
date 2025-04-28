using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Notifications
{
    public class NotificationPreference
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool EmailNotifications { get; set; }
        public bool PushNotifications { get; set; }
        public bool JobAlerts { get; set; }
        public bool ProposalUpdates { get; set; }
        public bool MessageNotifications { get; set; }
        public bool PaymentNotifications { get; set; }

        // Navigation properties
        public virtual ApplicationUser User { get; set; }
    }
}
