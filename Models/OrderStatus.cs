using System.ComponentModel.DataAnnotations;


namespace bangazon_issues.Models
{
    public class OrderStatus
    {
        public enum StatusOfOrder
        {
            Pending,
            Backordered,
            Completed,
            Shipped,
            Delivered,
            Cancelled
        }

        [Key]
        public string OrderStatusId { get; set; } = Guid.NewGuid().ToString();
        public StatusOfOrder OrderState { get; set; }

    }
}
