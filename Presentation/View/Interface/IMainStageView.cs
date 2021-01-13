using System;

namespace Presentation.View.Interface
{
    public interface IMainStageView : IStageView
    {
        Action OnLogoutClick { set; }
        Action OnLoginClick { set; }
        Action OnRegisterClick { set; }
        bool LogoutEnabled { set; }
        bool LoginEnabled { set; }
        bool RegisterEnabled { set; }
        string Username { set; }
    }
}
