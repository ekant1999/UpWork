using Contract = UpWork.Core.Entities.Contracts.Contract;
using UpWork.Core.Entities.Proposals;
using UpWork.Core.Entities.Skills;
using UpWork.Core.Entities.Portfolios;

namespace UpWork.Core.Entities.Identity
{
    public class FreelancerUser
    {
        public string UserId { get; set; } // FK to ApplicationUser

        // Freelance Professional Info
        public string ProfessionalTitle { get; set; }
        public string Overview { get; set; }
        public decimal HourlyRate { get; set; }
        public string ExperienceLevel { get; set; } // Beginner, Intermediate, Expert

        // Availability
        public string AvailabilityStatus { get; set; } // Available, Partially Available, Not Available
        public int WeeklyAvailableHours { get; set; }
        public DateTime AvailableFrom { get; set; }

        // Payment Info
        public string PaymentMethod { get; set; }
        public string BankAccount { get; set; }
        public string PayPalEmail { get; set; }

        // Verification Info
        public bool IdentityVerified { get; set; }

        // Education & Certifications
        public string Education { get; set; }
        public List<string> Certifications { get; set; } = new();

        // Navigation properties
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<FreelancerSkill> Skills { get; set; } = new List<FreelancerSkill>(); // Many-to-many with Skill
        public virtual ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
        public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
        public virtual ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }

}