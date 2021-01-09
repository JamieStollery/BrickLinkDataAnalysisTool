using Data.Common.Model;
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
