using UpWork.Core.Entities.Profile;

namespace UpWork.Core.Entities.Identity
{
    public class FreelancerUser : ApplicationUser
    {
        public decimal HourlyRate { get; set; }
        public string ExperienceLevel { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }

        // Navigation property
        public virtual FreelancerProfile FreelancerProfile { get; set; }
    }

}