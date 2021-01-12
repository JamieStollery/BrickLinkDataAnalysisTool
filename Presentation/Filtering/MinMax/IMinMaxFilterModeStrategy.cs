using Presentation.Model.Orders;
using System.Collections.Generic;

namespace Presentation.Filtering.MinMax
{
    public interface IMinMaxFilterModeStrategy
    {
        IEnumerable<Order> Filter(IEnumerable<Order> orders, int count);
    }
}
