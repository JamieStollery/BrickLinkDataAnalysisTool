using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter
{
    public class MenuPresenter : PresenterBase<IMenuView, MainStagePresenter>
    {
        public MenuPresenter(IMenuView view, MainStagePresenter stagePresenter) : base(view, stagePresenter)
        {
            View.OnLogoutClick = () => IsLoggedIn = false;
            View.OnLoginClick = () => StagePresenter.OpenLoginView();
            View.OnRegisterClick = () => StagePresenter.OpenRegisterView();
        }

        public bool IsLoggedIn
        {
            set
            {
                View.LogoutEnabled = value;
                View.LoginEnabled = !value;
                View.RegisterEnabled = !value;
            }
        }
    }
}
