using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Register
{
    public interface IRegisterPresenter : IPresenter
    {
        IRegisterView View { get; }
        Action OpenLoginView { set; }
    }
}
