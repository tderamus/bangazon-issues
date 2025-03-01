using System.ComponentModel.DataAnnotations;


namespace bangazon_issues.Models
{
    public class OrderStatus
    {
        internal object? OrderStat;
        [Key]
        public int OrderStatusId { get; set; }
        public enum OrderStatusEnum
        {
            Pending,
            Backordered,
            Completed,
            Shipped,
            Delivered,
            Cancelled
        }
    }
}
