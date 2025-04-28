using System.Diagnostics.Contracts;
using UpWork.Core.Entities.Identity;
using UpWork.Core.Entities.Jobs;
using Contract = UpWork.Core.Entities.Contracts.Contract;

namespace UpWork.Core.Entities.Proposals
{
    public class Proposal
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string FreelancerUserId { get; set; }

        public string CoverLetterText { get; set; } // For simple typed text
        public string CoverLetterFileUrl { get; set; } // If user uploads a PDF or DOC

        public decimal BidAmount { get; set; }
        public string BidType { get; set; }
        public int EstimatedHours { get; set; }
        public int EstimatedDays { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; }

        public virtual Job Job { get; set; }
        public virtual FreelancerUser FreelancerUser { get; set; }
        public virtual Contract Contract { get; set; }
    }

}
