namespace Presentation.Model.Items
{
    public class Item
    {
        public Item(string number, int inventoryId, string name, ItemType type, int categoryId, int colorId, int quantity, ItemCondition condition, string completeness, string description, string remarks, Price originalPrice, Price displayPrice)
        {
            Number = number;
            InventoryId = inventoryId;
            Name = name;
            Type = type;
            CategoryId = categoryId;
            ColorId = colorId;
            Quantity = quantity;
            Condition = condition;
            Completeness = completeness;
            Description = description;
            Remarks = remarks;
            OriginalPrice = originalPrice;
            DisplayPrice = displayPrice;
        }
        
        public string Number { get; }
        public int InventoryId { get; }
        public string Name { get; }
        public ItemType Type { get; }
        public int CategoryId { get; }
        public int ColorId { get; }
        public int Quantity { get; }
        public ItemCondition Condition { get; }
        public string Completeness { get; }
        public string Description { get; }
        public string Remarks { get; }
        public Price OriginalPrice { get; }
        public Price DisplayPrice { get; }
    }
}
