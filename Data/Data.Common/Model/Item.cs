namespace Data.Common.Model
{
    public class Item
    {
        public Item(string number, ItemType itemType, ItemCondition itemCondition)
        {
            Number = number;
            ItemType = itemType;
            ItemCondition = itemCondition;
        }

        public string Number { get; }
        public ItemType ItemType { get; }
        public ItemCondition ItemCondition { get; }
    }
}
