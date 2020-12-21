using Presentation.Presenter.Stage;
using Presentation.View.Interface;

namespace Presentation.Presenter
{
    public class RegisterPresenter : PresenterBase<IRegisterView, ChildStagePresenter>
    {
        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter) : base(view, stagePresenter)
        {
            View.OnRegisterButtonClick = () => Register();
        }

        private void Register()
        {
            // Register
            StagePresenter.CloseView(View);
            StagePresenter.OpenLoginView();
        }
    }
}
