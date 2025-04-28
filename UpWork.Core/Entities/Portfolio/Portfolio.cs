using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Portfolios
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string FreelancerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CompletionDate { get; set; }

        // Navigation properties
        public virtual FreelancerUser Freelancer { get; set; }
    }
}
