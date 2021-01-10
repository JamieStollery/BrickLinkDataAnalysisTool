using System;
using System.Collections.Generic;

namespace Presentation.View.Interface
{
    public interface IOrderView : IView
    {
        Action OnSearchButtonClick { set; }
        Action OnFilterChanged { set; }
        Action<int> OnOrderDoubleClick { set; }
        IEnumerable<string> ItemTypes { get; set; }
        IEnumerable<object> Orders { set; }
        string ItemTypeFilterMode { get; }
        string ItemConditionFilterMode { get; }
        string ItemCondition { get; }
        IEnumerable<string> ItemConditions { set; }
    }
}
