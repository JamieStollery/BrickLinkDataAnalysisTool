using System.Collections.Generic;

namespace Presentation.Filtering.MinMax
{
    public interface IMinMaxFilterModeStrategy<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> values, int count);
    }
}
