using UpWork.Core.Entities.Identity;
using UpWork.Core.Entities.Skills;

namespace UpWork.Core.Entities.Profile
{
    public class FreelancerProfile
    {
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public string Education { get; set; }
        public List<string> Certifications { get; set; }
        public int TotalProjectsCompleted { get; set; }
        public int TotalHoursWorked { get; set; }
        public double SuccessRate { get; set; }
        public double AverageRating { get; set; }
        public bool IdentityVerified { get; set; }

        // Work-related info
        public string AvailabilityStatus { get; set; } // Available, Partially Available, Not Available
        public int WeeklyAvailableHours { get; set; }
        public DateTime AvailableFrom { get; set; }

        // Payment info
        public string PaymentMethod { get; set; }
        public string BankAccount { get; set; }
        public string PayPalEmail { get; set; }

        // Navigation property to FreelancerUser
        public virtual FreelancerUser FreelancerUser { get; set; }

        // Navigation property to Skills (many-to-many)
        public virtual ICollection<FreelancerSkill> Skills { get; set; } = new List<FreelancerSkill>();

    }
}
