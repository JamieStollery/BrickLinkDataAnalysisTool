using Data.Common;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class OrderRepository : IOrderRepository
    {
        public Task<IEnumerable<Order>> GetOrders()
        {
            var orders = new List<Order>()
            {
                new Order(1, new List<Item>()
                {
                    new Item("a1", ItemType.Part, ItemCondition.New),
                    new Item("a2", ItemType.Part, ItemCondition.New)
                }),
                new Order(2, new List<Item>()
                {
                    new Item("b1", ItemType.Minifig, ItemCondition.Used),
                    new Item("b2", ItemType.Minifig, ItemCondition.Used)
                }),
                new Order(3, new List<Item>()
                {
                    new Item("c1", ItemType.Part, ItemCondition.Used),
                    new Item("c2", ItemType.Minifig, ItemCondition.New)
                })
            };
            return Task.FromResult<IEnumerable<Order>>(orders);
        }
    }
}
