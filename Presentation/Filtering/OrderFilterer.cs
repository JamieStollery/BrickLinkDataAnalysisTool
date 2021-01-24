using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering
{
    public class OrderFilterer : IOrderFilterer
    {
        private readonly Func<AnyAllFilterMode, IAnyAllFilterModeStrategy> _anyAllFilterModeStrategyFactory;
        private readonly Func<string, MinMaxFilterMode, IMinMaxFilterModeStrategy> _minMaxFilterModeStrategyFactory;
        private readonly Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy> _strictLooseFilterModeStrategyFactory;

        public OrderFilterer(Func<AnyAllFilterMode, IAnyAllFilterModeStrategy> anyAllFilterModeStrategyFactory,
            Func<string, MinMaxFilterMode, IMinMaxFilterModeStrategy> minMaxFilterModeStrategyFactory,
            Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy> strictLooseFilterModeStrategyFactory)
        {
            _anyAllFilterModeStrategyFactory = anyAllFilterModeStrategyFactory;
            _minMaxFilterModeStrategyFactory = minMaxFilterModeStrategyFactory;
            _strictLooseFilterModeStrategyFactory = strictLooseFilterModeStrategyFactory;
        }

        public IReadOnlyList<Order> FilterByOrderStatus(IReadOnlyList<Order> orders, IReadOnlyList<OrderStatus> statuses)
        {
            if (orders is null) throw new ArgumentNullException(nameof(orders));
            if (statuses is null) throw new ArgumentNullException(nameof(statuses));

            return statuses.Count > 0 ? orders.Where(order => !(order is null) && statuses.Contains(order.Status)).ToList() : orders;
        }

        public IReadOnlyList<Order> FilterByItemType(IReadOnlyList<Order> orders, IReadOnlyList<ItemType> itemTypes, AnyAllFilterMode? filterMode)
        {
            if (orders is null) throw new ArgumentNullException(nameof(orders));
            if (itemTypes is null) throw new ArgumentNullException(nameof(itemTypes));

            return (itemTypes.Count > 0 && !(filterMode is null)) ?
                _anyAllFilterModeStrategyFactory(filterMode.Value).Filter(orders, item => !(item is null) && itemTypes.Contains(item.Type)).ToList() : orders;
        }

        public IReadOnlyList<Order> FilterByItemCondition(IReadOnlyList<Order> orders, ItemCondition? itemCondition, AnyAllFilterMode? filterMode)
        {
            if (orders is null) throw new ArgumentNullException(nameof(orders));

            return (!(itemCondition is null) && !(filterMode is null)) ?
                _anyAllFilterModeStrategyFactory(filterMode.Value).Filter(orders, item => !(item is null) && item.Condition == itemCondition.Value).ToList() : orders;
        }

        public IReadOnlyList<Order> FilterByItemCount(IReadOnlyList<Order> orders, int itemCount, string countType, MinMaxFilterMode? filterMode)
        {
            if (orders is null) throw new ArgumentNullException(nameof(orders));

            if (!(filterMode is null))
            {
                var strategy = _minMaxFilterModeStrategyFactory(countType, filterMode.Value);

                if (!(strategy is null))
                {
                    return _minMaxFilterModeStrategyFactory(countType, filterMode.Value).Filter(orders, itemCount).ToList();
                }
            }
            return orders;
        }

        public IReadOnlyList<Order> FilterByOrderSearch(IReadOnlyList<Order> orders, string searchValue, string searchType, StrictLooseFilterMode? filterMode)
        {
            if (orders is null) throw new ArgumentNullException(nameof(orders));

            if (!(filterMode is null))
            {
                var strategy = _strictLooseFilterModeStrategyFactory(searchType, filterMode.Value);

                if (!(strategy is null) && !string.IsNullOrWhiteSpace(searchValue))
                {
                    return strategy.Filter(orders, searchValue).ToList();
                }
            }
            return orders;
        }
    }
}
