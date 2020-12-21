using Presentation.Presenter.Stage;
using Presentation.View.Interface;

namespace Presentation.Presenter
{
    public class LoginPresenter : PresenterBase<ILoginView, ChildStagePresenter>
    {
        public LoginPresenter(ILoginView view, ChildStagePresenter stagePresenter) : base(view, stagePresenter)
        {
            View.OnLoginButtonClick = () => Login();
            View.OnRegisterButtonClick = () => OpenRegisterView();
        }

        private void Login()
        {
            // Login
            StagePresenter.CloseView(View);
            StagePresenter.CloseStage();
        }

        private void OpenRegisterView()
        {
            StagePresenter.CloseView(View);
            StagePresenter.OpenRegisterView();
        }
    }
}
