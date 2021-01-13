using System;

namespace Presentation.View.Interface
{
    public interface ILoginView : IView
    {
        Action OnLoginButtonClick { set; }
        Action OnRegisterButtonClick { set; }
        string Username { get; }
        string Password { get; }
        string Error { set; }
    }
}
