using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class Orders
    {
        [Key]
        public required int OrdersId { get; set; }
        public required int Quantity { get; set; }
        public required DateTime OrderDate { get; set; }
        public bool IsFullfilled { get; set; }
        public decimal TotalPrice { get; set; }
        public required DateTime PaymentDate { get; set; }
        public Customers? Customer { get; set; }
        public Payments? Payment { get; set; }
        public Products? Product { get; set; }
        public Sellers? Seller { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public OrderItems? OrderItems { get; set; }



    }
}