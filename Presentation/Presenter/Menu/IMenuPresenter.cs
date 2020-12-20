using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Menu
{
    public interface IMenuPresenter
    {
        IMenuView View { get; }
        Action OpenLoginView { set; }
        Action OpenRegisterView { set; }
        bool IsLoggedIn { set; }
    }
}
