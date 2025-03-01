using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class OrderItems
    {
        [Key]
        public required int OrderItemsId { get; set; }
        public Orders? Orders { get; set; }
        public Products? Products { get; set; }  
        public required int Quantity { get; set; }
        public required decimal TotalPrice { get; set; }
    }
}