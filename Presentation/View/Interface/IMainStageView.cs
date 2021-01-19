using System;

namespace Presentation.View.Interface
{
    public interface IMainStageView : IStageView
    {
        Action OnLogoutClick { set; }
        Action OnLoginClick { set; }
        Action OnRegisterClick { set; }
        Action OnChangeDataModeClick { set; }
        Action OnUpdateDatabaseClick { set; }
        Action OnClearDatabaseClick { set; }
        bool LogoutEnabled { set; }
        bool LoginEnabled { set; }
        bool RegisterEnabled { set; }
        bool DatabaseControlsEnabled { set; }
        string Username { set; }
        string DataMode { set; }
        string Status { set; }
        int ProgressBarLength { set; }
        int ProgressBarProgress { get; set; }
    }
}
