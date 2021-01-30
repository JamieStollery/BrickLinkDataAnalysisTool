using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.StrictLoose
{
    public class OrderSearchFilterStrictStrategy : IStrictLooseFilterModeStrategy<Order>
    {
        private readonly Func<Order, string> _getOrderProperty;

        public OrderSearchFilterStrictStrategy(Func<Order, string> orderProperty)
        {
            _getOrderProperty = orderProperty;
        }

        public IEnumerable<Order> Filter(IEnumerable<Order> orders, string searchValue) => orders.Where(order => _getOrderProperty(order) == searchValue);
    }
}
