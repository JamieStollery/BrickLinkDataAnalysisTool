using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Menu
{
    public class MenuPresenter : IMenuPresenter
    {
        public bool IsLoggedIn
        {
            set
            {
                View.LogoutEnabled = value;
                View.LoginEnabled = !value;
                View.RegisterEnabled = !value;
            }
        }

        public MenuPresenter(IMenuView view)
        {
            View = view;
            View.OnLogoutClick = () => IsLoggedIn = false;
            View.OnLoginClick = () => OpenLoginView();
            View.OnRegisterClick = () => OpenRegisterView();
        }

        public IMenuView View { get; }

        public Action OpenLoginView { private get; set; }

        public Action OpenRegisterView { private get; set; }
    }
}
