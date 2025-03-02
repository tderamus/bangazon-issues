using System.ComponentModel.DataAnnotations;

namespace bangazon_issues.Models
{
    public class PaymentTypes
    {
        public enum PmtType
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

        [Key]
        public int PaymentTypeId { get; set; }
        public PmtType TypePayment { get; set; }
        
    }
}
