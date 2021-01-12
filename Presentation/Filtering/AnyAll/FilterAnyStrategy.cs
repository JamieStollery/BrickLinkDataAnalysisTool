using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.AnyAll
{
    public class FilterAnyStrategy : IAnyAllFilterModeStrategy
    {
        public IEnumerable<Order> Filter(IEnumerable<Order> orders, Func<Item, bool> predicate) => orders.Where(order => order.Items.Any(predicate));
    }
}
