namespace UpWork.Core.Entities.Skills
{
    public class Skill
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Category { get; set; }

        // Navigation property
        public virtual ICollection<FreelancerSkill> FreelancerSkills { get; set; } = new List<FreelancerSkill>();
    }

}
