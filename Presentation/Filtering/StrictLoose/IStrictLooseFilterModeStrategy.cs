using Presentation.Model.Orders;
using System.Collections.Generic;

namespace Presentation.Filtering.StrictLoose
{
    public interface IStrictLooseFilterModeStrategy
    {
        IEnumerable<Order> Filter(IEnumerable<Order> orders, string searchValue);
    }
}
