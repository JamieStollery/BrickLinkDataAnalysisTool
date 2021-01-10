namespace Presentation.Model.Orders
{
    public class Cost
    {
        public Cost(float subtotal, float grandTotal, string currencyCode)
        {
            Subtotal = subtotal;
            GrandTotal = grandTotal;
            CurrencyCode = currencyCode;
        }

        public float Subtotal { get; }
        public float GrandTotal { get; }
        public string CurrencyCode { get; }
    }
}
