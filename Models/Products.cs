using System.ComponentModel.DataAnnotations;
namespace bangazon_issues.Models
{
    public class Products
    {
        [Key]
        public string ProductId { get; set; } = Guid.NewGuid().ToString();
        public int ProductTypeId { get; set; }
        public string? SellerUid { get; set; }
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsAvailable { get; set; }
    }
}
