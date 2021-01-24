using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.StrictLoose
{
    public class OrderSearchFilterLooseStrategy : IStrictLooseFilterModeStrategy
    {
        private readonly Func<Order, string> _getOrderProperty;

        public OrderSearchFilterLooseStrategy(Func<Order, string> orderProperty)
        {
            _getOrderProperty = orderProperty;
        }

        public IEnumerable<Order> Filter(IEnumerable<Order> orders, string searchValue) => orders.Where(order => _getOrderProperty(order).Contains(searchValue, StringComparison.OrdinalIgnoreCase));
    }
}
