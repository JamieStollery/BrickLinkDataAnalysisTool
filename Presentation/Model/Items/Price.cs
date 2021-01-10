namespace Presentation.Model.Items
{
    public class Price
    {
        public Price(string unitPrice, string finalUnitPrice, string currencyCode)
        {
            UnitPrice = unitPrice;
            FinalUnitPrice = finalUnitPrice;
            CurrencyCode = currencyCode;
        }

        public string UnitPrice { get; }
        public string FinalUnitPrice { get; }
        public string CurrencyCode { get; }
    }
}
