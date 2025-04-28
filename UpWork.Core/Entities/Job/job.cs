using UpWork.Core.Entities.Identity;
using UpWork.Core.Entities.Proposals;
using UpWork.Core.Entities.Skills;
using Contract = UpWork.Core.Entities.Contracts.Contract;

namespace UpWork.Core.Entities.Jobs
{
    public class Job
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal MinBudget { get; set; }
        public decimal MaxBudget { get; set; }
        public string BudgetType { get; set; } // Hourly or Fixed
        public DateTime Deadline { get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; } // Open, InProgress, Completed, Closed
        public int ViewCount { get; set; }
        public int ProposalCount { get; set; }

        // Navigation properties
        public virtual ClientUser Client { get; set; }
        public virtual JobCategory Category { get; set; }
        public virtual ICollection<Skill> RequiredSkills { get; set; }
        public virtual ICollection<SavedJob> SavedByUsers { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
