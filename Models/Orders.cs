using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bangazon_issues.Models
{
    public class Orders
    {
        [Key]
        public string OrdersId { get; set; } = Guid.NewGuid().ToString();
        public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
        public required int Quantity { get; set; }
        public required DateTime OrderDate { get; set; }
        public bool IsFullfilled { get; set; }
        public decimal TotalPrice { get; set; }
        public required DateTime PaymentDate { get; set; }
        public Customers? Customer { get; set; }
        public string? PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        public Payments? Payment { get; set; }
        public Products? Product { get; set; }
        public Sellers? Seller { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        



    }
}