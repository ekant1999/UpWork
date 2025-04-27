using UpWork.Core.Entities.Profile;

namespace UpWork.Core.Entities.Skills
{
    public class FreelancerSkill
    {
        public int Id { get; set; }
        public int FreelancerProfileId { get; set; }
        public int SkillId { get; set; }
        public int ProficiencyLevel { get; set; } // 1-5 scale
        public int YearsOfExperience { get; set; }

        // Navigation properties
        public virtual FreelancerProfile FreelancerProfile { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
