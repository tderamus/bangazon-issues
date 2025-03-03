using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class SellerOrders
    {
        [Key]
        public string SellerOrdersId { get; set; } = Guid.NewGuid().ToString();
        public Sellers? Sellers { get; set; }
        public Orders? Orders { get; set; }
    }
}