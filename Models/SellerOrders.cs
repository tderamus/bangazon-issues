using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class SellerOrders
    {
        [Key]
        public required int SellerOrdersId { get; set; }
        public Sellers? Sellers { get; set; }
        public Orders? Orders { get; set; }
    }
}