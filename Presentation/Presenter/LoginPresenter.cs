using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ChildStagePresenter _stagePresenter;
        private readonly LoginRepository _loginRepository;
        private readonly User _user;

        public LoginPresenter(ILoginView view, ChildStagePresenter stagePresenter, LoginRepository loginRepository, User user)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _loginRepository = loginRepository;
            _user = user;

            _view.OnLoginButtonClick = () => Login();
            _view.OnRegisterButtonClick = () => OpenRegisterView();
        }

        public void OpenOrderView() => _stagePresenter.OpenView(_view);

        private async void Login()
        {
            _user.Username = _view.Username;
            _user.Password = _view.Password;

            var result = _user.Validate(UserValidationType.Login);

            if(!result.IsValid)
            {
                _user.Invalidate();
                _view.Error = result.Errors.First().ErrorMessage;
                return;
            }

            if (!await _loginRepository.Login(_user))
            {
                _user.Invalidate();
                _view.Error = "Invalid username or password";
                return;
            }

            _stagePresenter.CloseStage();
        }

        private void OpenRegisterView()
        {
            _stagePresenter.OpenRegisterView();
        }
    }
}
