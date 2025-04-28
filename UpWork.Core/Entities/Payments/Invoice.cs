using UpWork.Core.Entities.Payments;

namespace UpWork.Core.Entities.Payments
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // Issued, Paid, Cancelled

        public virtual Payment Payment { get; set; }
    }
}
