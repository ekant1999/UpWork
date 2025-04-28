using Jobs = UpWork.Core.Entities.Jobs;
using UpWork.Core.Entities.Skills;

namespace UpWork.Core.Entities.Job
{
    public class JobSkill
    {
        public int JobId { get; set; }
        public int SkillId { get; set; }
        public int MinimumLevel { get; set; }

        // Navigation properties
        public virtual Jobs.Job Job { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
