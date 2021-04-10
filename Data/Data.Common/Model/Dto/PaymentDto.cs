using System;

namespace Data.Common.Model.Dto
{
    public class PaymentDto
    {
        public string Method { get; set; }
        public string Status { get; set; }
        public DateTime Date_paid { get; set; }
        public string Currency_code { get; set; }
    }
}
