using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;

namespace Presentation.Presenter
{
    public class RegisterPresenter : PresenterBase<IRegisterView, ChildStagePresenter>
    {
        private readonly RegisterRepository _registerRepository;

        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter, RegisterRepository registerRepository) : base(view, stagePresenter)
        {
            _registerRepository = registerRepository;

            View.OnRegisterButtonClick = () => Register();
        }

        private async void Register()
        {
            // Register
            //await _registerRepository.Register();
            StagePresenter.CloseView(View);
            StagePresenter.OpenLoginView();
        }
    }
}
