using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.MinMax
{
    public class OrderItemCountFilterMaxStrategy : IMinMaxFilterModeStrategy<Order>
    {
        private readonly Func<Order, int> _getItemCountProperty;

        public OrderItemCountFilterMaxStrategy(Func<Order, int> itemCountProperty)
        {
            _getItemCountProperty = itemCountProperty;
        }

        public IEnumerable<Order> Filter(IEnumerable<Order> orders, int count) => orders.Where(order => _getItemCountProperty(order) <= count);
    }
}
