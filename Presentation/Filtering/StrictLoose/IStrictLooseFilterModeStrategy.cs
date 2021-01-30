using System.Collections.Generic;

namespace Presentation.Filtering.StrictLoose
{
    public interface IStrictLooseFilterModeStrategy<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> values, string searchValue);
    }
}
