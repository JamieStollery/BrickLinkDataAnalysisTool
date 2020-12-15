using System;

namespace Presentation.View.Interface
{
    public interface IRegisterView : IView
    {
        Action OnRegisterButtonClick { set; }
    }
}
