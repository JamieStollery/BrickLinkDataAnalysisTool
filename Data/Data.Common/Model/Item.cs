namespace Data.Common.Model
{
    public class Item
    {
        public Item(string number, ItemType itemType)
        {
            Number = number;
            ItemType = itemType;
        }

        public string Number { get; }
        public ItemType ItemType { get; }
    }
}
