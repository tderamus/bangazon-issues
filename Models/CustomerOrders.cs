using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class CustomerOrders
    {
        [Key]
        public int CustomerOrderId { get; set; }
        public Customers? Customer { get; set; }
        public Orders? Orders { get; set; }
        public Sellers? Seller { get; set; }
    }
}
