using Data.Common;
using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;

namespace Presentation.Presenter
{
    public class LoginPresenter : PresenterBase<ILoginView, ChildStagePresenter>
    {
        private readonly UserRepository _loginRepository;
        private readonly User _user;

        public LoginPresenter(ILoginView view, ChildStagePresenter stagePresenter, UserRepository loginRepository, User user) : base(view, stagePresenter)
        {
            _loginRepository = loginRepository;
            _user = user;

            View.OnLoginButtonClick = () => Login();
            View.OnRegisterButtonClick = () => OpenRegisterView();
        }

        private async void Login()
        {
            // Login
            if (string.IsNullOrWhiteSpace(View.Username) || string.IsNullOrWhiteSpace(View.Password))
            {
                View.Error = "All fields must contain a value";
                return;
            }

            if (!await _loginRepository.Login(View.Username))
            {
                View.Error = "Invalid username or password";
            }
            else
            {
                _user.Username = View.Username;

                StagePresenter.CloseView(View);
                StagePresenter.CloseStage();
            }
        }

        private void OpenRegisterView()
        {
            StagePresenter.CloseView(View);
            StagePresenter.OpenRegisterView();
        }
    }
}
