using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.View.Model;
using System.Collections.Generic;

namespace Presentation.Filtering
{
    public interface IItemFilterer
    {
        IReadOnlyList<ItemVm> FilterByItemCondition(IReadOnlyList<ItemVm> items, ItemCondition? condition);
        IReadOnlyList<ItemVm> FilterByItemSearch(IReadOnlyList<ItemVm> items, string searchValue, string searchType, StrictLooseFilterMode? filterMode);
        IReadOnlyList<ItemVm> FilterByItemType(IReadOnlyList<ItemVm> items, IReadOnlyList<ItemType> itemTypes);
        IReadOnlyList<ItemVm> FilterByItemColor(IReadOnlyList<ItemVm> items, IReadOnlyList<int> colorIds);
        IReadOnlyList<ItemVm> FilterByItemCount(IReadOnlyList<ItemVm> items, int value, MinMaxFilterMode? filterMode);
    }
}