
using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Skills
{
    public class FreelancerSkill
    {
        public int Id { get; set; }
        public string FreelancerId { get; set; }
        public int SkillId { get; set; }
        public int ProficiencyLevel { get; set; } // 1-5 scale
        public int YearsOfExperience { get; set; }

        // Navigation properties
        public virtual Skill Skill { get; set; }
        public virtual FreelancerUser FreelancerUser { get; set; }
    }
}
