using Contract = UpWork.Core.Entities.Contracts.Contract;

namespace UpWork.Core.Entities.Payments
{
    public class Payment
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public decimal Amount { get; set; }
        public decimal PlatformFee { get; set; } // optional
        public string Status { get; set; } // Pending, Completed, Failed
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
