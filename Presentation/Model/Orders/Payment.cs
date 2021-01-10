namespace Presentation.Model.Orders
{
    public class Payment
    {
        public Payment(string method, PaymentStatus status, string datePaid, string currencyCode)
        {
            Method = method;
            Status = status;
            DatePaid = datePaid;
            CurrencyCode = currencyCode;
        }
        public string Method { get; }
        public PaymentStatus Status { get; }
        public string DatePaid { get; }
        public string CurrencyCode { get; }
    }
}
