using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.MinMax
{
    public class ItemCountFilterMaxStrategy : IMinMaxFilterModeStrategy
    {
        private readonly Func<Order, int> _getItemCountProperty;

        public ItemCountFilterMaxStrategy(Func<Order, int> itemCountProperty)
        {
            _getItemCountProperty = itemCountProperty;
        }

        public IEnumerable<Order> Filter(IEnumerable<Order> orders, int count) => orders.Where(order => _getItemCountProperty(order) < count);
    }
}
