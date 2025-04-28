using UpWork.Core.Entities.Identity;
using Contract = UpWork.Core.Entities.Contracts.Contract;

namespace UpWork.UpWork.Core.Entities.Disputes
{
    public class Dispute
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string RaisedByUserId { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Open, InReview, Resolved, Closed
        public DateTime CreatedAt { get; set; }
        public DateTime? ResolvedAt { get; set; }

        // Navigation properties
        public virtual Contract Contract { get; set; }
        public virtual ApplicationUser RaisedByUser { get; set; }
    }

}
