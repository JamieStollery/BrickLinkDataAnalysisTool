using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Register
{
    public class RegisterPresenter : IRegisterPresenter
    {
        public RegisterPresenter(IRegisterView view)
        {
            View = view;
            View.OnRegisterButtonClick = () => Register();
        }

        public IRegisterView View { get; }

        public Action<IView> CloseView { private get; set; }

        public Action OpenLoginView { private get; set; }

        private void Register()
        {
            // Register
            CloseView(View);
            OpenLoginView();
        }
    }
}
