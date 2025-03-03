using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class SellerDashboard
    {
        [Key]
        public string SellerDashBoardId { get; set; } = Guid.NewGuid().ToString();
        public Sellers? Seller { get; set; }
        public decimal TotalRevenue { get; set; }
        // Read-only property to return formatted TotalRevenue
        public string FormattedTotalRevenue => TotalRevenue.ToString("C");
        public int TotalOrders { get; set; }
    }
}