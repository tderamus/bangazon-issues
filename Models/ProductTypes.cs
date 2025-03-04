using System.ComponentModel.DataAnnotations;
namespace bangazon_issues.Models
{
    public class ProductTypes
    {
        [Key]
        public string ProductTypeId { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
