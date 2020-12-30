using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class LoginPresenter : PresenterBase<ILoginView, ChildStagePresenter>
    {
        private readonly LoginRepository _loginRepository;
        private readonly User _user;

        public LoginPresenter(ILoginView view, ChildStagePresenter stagePresenter, LoginRepository loginRepository, User user) : base(view, stagePresenter)
        {
            _loginRepository = loginRepository;
            _user = user;

            View.OnLoginButtonClick = () => Login();
            View.OnRegisterButtonClick = () => OpenRegisterView();
        }

        private async void Login()
        {
            _user.Username = View.Username;
            _user.Password = View.Password;

            var result = _user.Validate(UserValidationType.Login);

            if(!result.IsValid)
            {
                _user.Invalidate();
                View.Error = result.Errors.First().ErrorMessage;
                return;
            }

            if (!await _loginRepository.Login(_user))
            {
                _user.Invalidate();
                View.Error = "Invalid username or password";
                return;
            }

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
