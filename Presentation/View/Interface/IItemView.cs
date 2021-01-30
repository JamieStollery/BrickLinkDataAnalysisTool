using System;
using System.Collections.Generic;

namespace Presentation.View.Interface
{
    public interface IItemView : IView
    {
        IEnumerable<string> ItemTypes { get; set; }

        string ItemSearchType { get; }
        string ItemSearchValue { get; }
        string ItemSearchFilterMode { get; }
        string ItemCondition { get; }

        Action OnBackButtonClick { set; }
        IEnumerable<object> Items { set; }
        Action OnViewOpened { set; }
        Action OnFilterChanged { set; }
        IEnumerable<string> ItemSearchTypes { set; }
        IEnumerable<string> ItemConditions { set; }
        IEnumerable<object> Colors { set; }
        int ItemCount { get; }
        string ItemCountFilterMode { get; }

        void RePaintItem(string number, int inventoryId);
    }
}
