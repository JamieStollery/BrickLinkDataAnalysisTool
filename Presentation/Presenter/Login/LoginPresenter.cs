using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Login
{
    public class LoginPresenter : ILoginPresenter
    {
        public LoginPresenter(ILoginView view)
        {
            View = view;
            View.OnLoginButtonClick = () => Login();
        }

        public ILoginView View { get; }

        public Action CloseStage { private get; set; }

        private void Login()
        {
            // Login
            CloseStage();
        }
    }
}
