using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.StrictLoose
{
    public class ItemSearchFilterStrictStrategy : IStrictLooseFilterModeStrategy<ItemVm>
    {
        private readonly Func<ItemVm, string> _getItemProperty;

        public ItemSearchFilterStrictStrategy(Func<ItemVm, string> itemProperty)
        {
            _getItemProperty = itemProperty;
        }

        public IEnumerable<ItemVm> Filter(IEnumerable<ItemVm> items, string searchValue) => items.Where(item => _getItemProperty(item) == searchValue);
    }

}
