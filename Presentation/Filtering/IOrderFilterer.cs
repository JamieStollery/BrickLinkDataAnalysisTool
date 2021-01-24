using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System.Collections.Generic;

namespace Presentation.Filtering
{
    public interface IOrderFilterer
    {
        IReadOnlyList<Order> FilterByItemCondition(IReadOnlyList<Order> orders, ItemCondition? itemCondition, AnyAllFilterMode? filterMode);
        IReadOnlyList<Order> FilterByItemCount(IReadOnlyList<Order> orders, int itemCount, string countType, MinMaxFilterMode? filterMode);
        IReadOnlyList<Order> FilterByItemType(IReadOnlyList<Order> orders, IReadOnlyList<ItemType> itemTypes, AnyAllFilterMode? filterMode);
        IReadOnlyList<Order> FilterByOrderSearch(IReadOnlyList<Order> orders, string searchValue, string searchType, StrictLooseFilterMode? filterMode);
        IReadOnlyList<Order> FilterByOrderStatus(IReadOnlyList<Order> orders, IReadOnlyList<OrderStatus> statuses);
    }
}