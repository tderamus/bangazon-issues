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
        public int AccountTypeId { get; set; }
        public AcctType TypeAcct { get; set; }
    }
}