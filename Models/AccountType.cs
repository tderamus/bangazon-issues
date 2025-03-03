using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class AccountType
    {
        public enum AcctType
        {
            Customer,
            Seller,
            Admin
        }

        [Key]
        public string AccountTypeId { get; set; } = Guid.NewGuid().ToString();
        public AcctType TypeAcct { get; set; }
    }
}