using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;

namespace Presentation.Filtering
{
    public interface IFilterModeStrategy
    {
        FilterMode Mode { get; }
        IEnumerable<Order> Filter(IEnumerable<Order> orders, Func<Item, bool> predicate);
    }
}
