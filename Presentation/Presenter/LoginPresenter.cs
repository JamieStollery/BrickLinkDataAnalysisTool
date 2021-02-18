using Data.Common.Model;
using Data.Common.Repository.Interface;
using FluentValidation;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ChildStagePresenter _stagePresenter;
        private readonly ILoginRepository _loginRepository;
        private readonly User _user;

        public LoginPresenter(ILoginView view, ChildStagePresenter stagePresenter, ILoginRepository loginRepository, User user)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _loginRepository = loginRepository;
            _user = user;

            _view.OnLoginButtonClick = () => Login();
            _view.OnRegisterButtonClick = () => OpenRegisterView();
        }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async void Login()
        {
            _user.Username = _view.Username;
            _user.Password = _view.Password;

            var (result, error) = await _loginRepository.Login(_user);
            if (!result)
            {
                _user.Invalidate();
                _view.Error = error;
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
