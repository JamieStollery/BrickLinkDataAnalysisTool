using Presentation.View.Model;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Filtering.MinMax
{
    public class ItemCountFilterMaxStrategy : IMinMaxFilterModeStrategy<ItemVm>
    {
        public IEnumerable<ItemVm> Filter(IEnumerable<ItemVm> items, int count)
        {
            return items.Where(item => item.Quantity <= count);
        }
    }
}
