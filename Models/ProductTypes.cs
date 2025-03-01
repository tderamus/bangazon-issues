using System.ComponentModel.DataAnnotations;
namespace bangazon_issues.Models
{
    public class ProductTypes
    {
        [Key]
        public int ProductTypeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
