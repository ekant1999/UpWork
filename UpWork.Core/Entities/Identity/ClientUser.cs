using Job = UpWork.Core.Entities.Jobs.Job;
using Contract = UpWork.Core.Entities.Contracts.Contract;
namespace UpWork.Core.Entities.Identity
{
    public class ClientUser
    {
        public required string  UserId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanySize { get; set; }
        public string? Industry { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? Description { get; set; }

        // Address fields
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        // Business details
        public string? BusinessType { get; set; }
        public string? TaxIdentificationNumber { get; set; }

        // Payment info
        public string? PaymentMethod { get; set; }
        public bool PaymentVerified { get; set; }

        // Navigation properties
        public virtual required ApplicationUser User { get; set; }
        public virtual ICollection<Jobs.Job>? Jobs { get; set; }
        public virtual ICollection<Contract>? Contracts { get; set; }
    }


}
