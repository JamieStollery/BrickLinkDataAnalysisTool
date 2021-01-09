using System;
using System.Collections.Generic;

namespace Presentation.View.Interface
{
    public interface IItemView : IView
    {
        Action OnBackButtonClick { set; }
    }
}
