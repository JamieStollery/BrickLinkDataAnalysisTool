using System.Collections.Generic;

namespace Data.Common.Model
{
    public class Order
    {
        public Order(int id)
        {
            Id = id;
        }

        public Order(int id, IReadOnlyList<Item> items) : this(id)
        {
            Items = items;
        }

        public int Id { get; }
        public IReadOnlyList<Item> Items { get; }
    }
}
