using UpWork.Core.Entities.Identity;

namespace UpWork.Core.Entities.Profile
{
    public class ClientProfile : UserProfile
    {
        public string CompanyDescription { get; set; }
        public int TotalProjectsPosted { get; set; }
        public int TotalHires { get; set; }
        public decimal TotalSpent { get; set; }
        public double AverageRating { get; set; }
        public string PaymentMethod { get; set; }
        public bool PaymentVerified { get; set; }

        // Company address
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // Business details
        public string BusinessType { get; set; }
        public string TaxIdentificationNumber { get; set; }

        // Navigation property to ClientUser
        public virtual ClientUser ClientUser { get; set; }
    }
}
