using UpWork.Core.Entities.Identity;
using UpWork.Core.Entities.Jobs;
using UpWork.Core.Entities.Payments;
using UpWork.Core.Entities.Proposals;
using UpWork.Core.Entities.Disputes;

namespace UpWork.Core.Entities.Contracts
{
    public class Contract
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int ProposalId { get; set; }
        public string ClientUserId { get; set; }
        public string FreelancerUserId { get; set; }

        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; } // Hourly or Fixed
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; } // Draft, Active, Completed, Cancelled, Disputed
        public string TermsAndConditions { get; set; }
        public bool ClientAccepted { get; set; }
        public bool FreelancerAccepted { get; set; }

        // Navigation properties
        public virtual Job Job { get; set; }
        public virtual Proposal Proposal { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual FreelancerUser FreelancerUser { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual Dispute Dispute { get; set; }
    }
}
