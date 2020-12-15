using Presentation.View.Interface;
using System;

namespace Presentation.Presenter
{
    public interface IPresenter
    {
        Action<IView> CloseView { set; }
    }
}
