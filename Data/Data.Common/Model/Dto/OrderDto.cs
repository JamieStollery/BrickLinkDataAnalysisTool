namespace Data.Common.Model.Dto
{
    public class OrderDto
    {
        public int Order_id { get; set; }
        public string Date_ordered { get; set; }
        public string Seller_name { get; set; }
        public string Store_name { get; set; }
        public string Buyer_name { get; set; }
        public int Total_count { get; set; }
        public int Unique_count { get; set; }
        public string Status { get; set; }
        public PaymentDto Payment { get; set; }
        public CostDto Cost { get; set; }
    }
}
