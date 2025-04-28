using UpWork.Core.Entities.Communication;
using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Communication
{
    public class Message
    {
        public int Id { get; set; }
        public int ChatRoomId { get; set; }
        public string SenderId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

        // Navigation properties
        public virtual ChatRoom ChatRoom { get; set; }
        public virtual ApplicationUser Sender { get; set; }
        public virtual ICollection<FileAttachment> Attachments { get; set; }
    }
}
