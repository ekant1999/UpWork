using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Jobs
{
    public class SavedJob
    {
        public string UserId { get; set; }
        public int JobId { get; set; }
        public DateTime SavedDate { get; set; }

        // Navigation properties
        public virtual ApplicationUser User { get; set; }
        public virtual Job Job { get; set; }
    }

}
