using UpWork.UpWork.Core.Entities.Communication;

namespace UpWork.Core.Entities.Communication
{
    public class ChatRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? RelatedJobId { get; set; }
        public int? RelatedContractId { get; set; }

        // Navigation properties
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<ChatRoomUser> Users { get; set; }
    }
}
