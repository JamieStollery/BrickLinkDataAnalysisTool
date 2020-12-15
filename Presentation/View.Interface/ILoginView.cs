using System;

namespace Presentation.View.Interface
{
    public interface ILoginView : IView
    {
        Action OnLoginButtonClick { set; }
    }
}
