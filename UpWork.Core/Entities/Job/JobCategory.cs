namespace UpWork.Core.Entities.Jobs
{
    public class JobCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
