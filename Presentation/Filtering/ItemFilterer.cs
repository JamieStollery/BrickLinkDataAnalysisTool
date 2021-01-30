using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentation.Filtering
{
    public class ItemFilterer : IItemFilterer
    {
        private readonly Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy<ItemVm>> _strictLooseFilterModeStrategyFactory;
        private readonly Func<MinMaxFilterMode, IMinMaxFilterModeStrategy<ItemVm>> _minMaxFilterModeStrategyFactory;

        public ItemFilterer(Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy<ItemVm>> strictLooseFilterModeStrategyFactory,
            Func<MinMaxFilterMode, IMinMaxFilterModeStrategy<ItemVm>> minMaxFilterModeStrategyFactory)
        {
            _strictLooseFilterModeStrategyFactory = strictLooseFilterModeStrategyFactory;
            _minMaxFilterModeStrategyFactory = minMaxFilterModeStrategyFactory;
        }

        public IReadOnlyList<ItemVm> FilterByItemSearch(IReadOnlyList<ItemVm> items, string searchValue, string searchType, StrictLooseFilterMode? filterMode)
        {
            if (items is null) throw new ArgumentNullException(nameof(items));

            if (!(filterMode is null))
            {
                var strategy = _strictLooseFilterModeStrategyFactory(searchType, filterMode.Value);

                if (!(strategy is null) && !string.IsNullOrWhiteSpace(searchValue))
                {
                    return strategy.Filter(items, searchValue).ToList();
                }
            }
            return items;
        }

        public IReadOnlyList<ItemVm> FilterByItemCondition(IReadOnlyList<ItemVm> items, ItemCondition? condition)
        {
            if (items is null) throw new ArgumentNullException(nameof(items));

            if (condition is null) return items;

            return items.Where(item => Enum.Parse<ItemCondition>(item.Condition) == condition.Value).ToList();
        }

        public IReadOnlyList<ItemVm> FilterByItemType(IReadOnlyList<ItemVm> items, IReadOnlyList<ItemType> itemTypes)
        {
            if (items is null) throw new ArgumentNullException(nameof(items));
            if (itemTypes is null) throw new ArgumentNullException(nameof(itemTypes));

            if (itemTypes.Count == 0) return items;

            return items.Where(item => itemTypes.Contains(Enum.Parse<ItemType>(item.Type))).ToList();
        }

        public IReadOnlyList<ItemVm> FilterByItemColor(IReadOnlyList<ItemVm> items, IReadOnlyList<int> colorIds)
        {
            if (items is null) throw new ArgumentNullException(nameof(items));
            if (colorIds is null) throw new ArgumentNullException(nameof(colorIds));

            if (colorIds.Count == 0) return items;

            return items.Where(item => colorIds.Contains(item.ColorId)).ToList();
        }

        public IReadOnlyList<ItemVm> FilterByItemCount(IReadOnlyList<ItemVm> items, int count, MinMaxFilterMode? filterMode)
        {
            if (items is null) throw new ArgumentNullException(nameof(items));

            if (filterMode is null) return items;

            return _minMaxFilterModeStrategyFactory(filterMode.Value).Filter(items, count).ToList();
        }
    }
}
