using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Communication
{
    public class ChatRoomUser
    {
        public int ChatRoomId { get; set; }
        public string UserId { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime? LastSeen { get; set; }

        // Navigation properties
        public virtual ChatRoom ChatRoom { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
