using System;

namespace Presentation.Model.Orders
{
    public class Payment
    {
        public Payment(string method, PaymentStatus status, DateTime datePaid, string currencyCode)
        {
            Method = method;
            Status = status;
            DatePaid = datePaid;
            CurrencyCode = currencyCode;
        }
        public string Method { get; }
        public PaymentStatus Status { get; }
        public DateTime DatePaid { get; }
        public string CurrencyCode { get; }
    }
}
