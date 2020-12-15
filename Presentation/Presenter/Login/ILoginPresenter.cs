using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Login
{
    public interface ILoginPresenter
    {
        ILoginView View { get; }
        Action CloseStage { set; }
    }
}
