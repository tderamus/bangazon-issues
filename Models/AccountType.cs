using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class AccountType
    {
        internal object? AcctType;

        [Key]
        public int AccountTypeId { get; set; }
        public enum AccountTypeEnum
        {
            Customer,
            Seller,
            Admin
        }
    }
}