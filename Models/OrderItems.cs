using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bangazon_issues.Models
{
    public class OrderItems
    {
        [Key]
        public string OrderItemsId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string? OrdersId { get; set; }

        [ForeignKey("OrdersId")]
        public Orders? Orders { get; set; }
        public Products? Products { get; set; }  
        public required int Quantity { get; set; }
        public required decimal TotalPrice { get; set; }
    }
}