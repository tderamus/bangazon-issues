using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bangazon_issues.Models
{
    public class CustomerOrders
    {
        [Key]
        public string CustomerOrderId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string CustomerUid { get; set; }
        [ForeignKey("CustomerUid")]
        public Customers Customer { get; set; }
        public Orders? Orders { get; set; }
        public Sellers? Seller { get; set; }
    }
}
