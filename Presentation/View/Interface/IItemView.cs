using System;
using System.Collections.Generic;

namespace Presentation.View.Interface
{
    public interface IItemView : IView
    {
        Action OnBackButtonClick { set; }
        IEnumerable<object> Items { set; }
        Action OnViewOpened { set; }

        void RePaintItem(string number, int inventoryId);
    }
}
