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
            View.OnRegisterButtonClick = () =>
            {
                CloseView(View);
                OpenRegisterView();
            };

        }

        public ILoginView View { get; }

        public Action<IView> CloseView { private get; set; }

        public Action CloseStage { private get; set; }

        public Action OpenRegisterView { private get; set; }

        private void Login()
        {
            // Login
            CloseStage();
        }
    }
}
