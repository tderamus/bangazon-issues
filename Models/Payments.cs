using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class Payments
    {
        [Key]
        public string PaymentId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? AccountNumber { get; set; }
        public PaymentTypes? PaymentTypes { get; set; }

        public Customers? Customer { get; set; }
        public Sellers? Seller { get; set; }
        public Orders? Orders { get; set; }
    }
}
