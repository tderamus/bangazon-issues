using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class PaymentTypes
    {
        internal object? PmtType;
        [Key]
        public int PaymentTypeId { get; set; }
        public enum PaymentTypeEnum
        {
            Visa,
            MasterCard,
            AmericanExpress,
            Discover,
            PayPal,
            CreditCard,
            Venmo,
            Zelle,
            CashApp,
            ApplePay,
            GooglePay,
            PurchaseOrder,
            Check
        }
    }
}
