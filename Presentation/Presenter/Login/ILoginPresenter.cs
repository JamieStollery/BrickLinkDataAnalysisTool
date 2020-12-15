using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Login
{
    public interface ILoginPresenter : IPresenter
    {
        ILoginView View { get; }
        Action CloseStage { set; }
        Action OpenRegisterView { set; }
    }
}
