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
        public int OrderStatusId { get; set; }
        public StatusOfOrder OrderState { get; set; }

    }
}
