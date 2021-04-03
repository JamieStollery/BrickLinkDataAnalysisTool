namespace Presentation.Model.Items
{
    public class Price
    {
        public Price(float unitPrice, float finalUnitPrice, string currencyCode)
        {
            UnitPrice = unitPrice;
            FinalUnitPrice = finalUnitPrice;
            CurrencyCode = currencyCode;
        }

        public float UnitPrice { get; }
        public float FinalUnitPrice { get; }
        public string CurrencyCode { get; }
    }
}
