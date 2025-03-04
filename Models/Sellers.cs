using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class Sellers
    {
        [Key]
        public  string SellerId { get; set; } = Guid.NewGuid().ToString();
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public AccountType? AccountType { get; set; }
    }
}