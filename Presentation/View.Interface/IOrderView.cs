using System;
using System.Collections.Generic;

namespace Presentation.View.Interface
{
    public interface IOrderView : IView
    {
        // get/set
        IEnumerable<string> ItemTypes { get; set; }
        // get
        string ItemCondition { get; }
        string ItemCountType { get; }
        int ItemCount { get; }
        string ItemTypeFilterMode { get; }
        string ItemConditionFilterMode { get; }
        string ItemCountTypeFilterMode { get; }
        // set
        Action OnSearchButtonClick { set; }
        Action OnFilterChanged { set; }
        Action<int> OnOrderDoubleClick { set; }
        IEnumerable<object> Orders { set; }
        IEnumerable<string> ItemConditions { set; }
        IEnumerable<string> ItemCountTypes { set; }
    }
}
