using Data.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering
{
    public class FilterAnyStrategy : IFilterModeStrategy
    {
        public FilterMode Mode => FilterMode.Any;

        public IEnumerable<Order> Filter(IEnumerable<Order> orders, Func<Item, bool> predicate) => orders.Where(order => order.Items.Any(predicate));
    }
}
