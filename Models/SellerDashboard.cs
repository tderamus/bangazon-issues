using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class SellerDashboard
    {
        [Key]
        public int SellerDashBoardId { get; set; }
        public Sellers? Seller { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalOrders { get; set; }
    }
}