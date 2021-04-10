using System;

namespace Presentation.View.Model
{
    public class OrderVm
    {
        public int Id { get; set; }
        public string DateOrdered { get; set; }
        public string BuyerName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string GrandTotal { get; set; }
    }
}
