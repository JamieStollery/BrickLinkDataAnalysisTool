using System;

namespace Presentation.View.Interface
{
    public interface IRegisterView : IView
    {
        Action OnRegisterButtonClick { set; }
        string Username { get; }
        string Password { get; }
        string ConsumerKey { get; }
        string ConsumerSecret { get; }
        string TokenValue { get; }
        string TokenSecret { get; }
        string Error { set; }
    }
}
