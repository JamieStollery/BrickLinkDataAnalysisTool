namespace Data.Common.Model.Dto
{
    public class OrderItemDto
    {
        public ItemDto Item { get; set; }
        public int Inventory_id { get; set; }
        public int Color_id { get; set; }
        public int Quantity { get; set; }
        public char New_or_used { get; set; }
        public string Completeness { get; set; }
        public string Unit_price { get; set; }
        public string Unit_price_final { get; set; }
        public string Disp_unit_price { get; set; }
        public string Disp_unit_price_final { get; set; }
        public string Currency_code { get; set; }
        public string Disp_currency_code { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
    }
}
