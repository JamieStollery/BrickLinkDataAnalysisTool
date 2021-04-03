using Data.Common.Model;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginRepository _loginRepository;
        private readonly IStagePresenter _stagePresenter;
        private readonly IOption<User> _userOption;

        public LoginPresenter(ILoginView view, ILoginRepository loginRepository, IStagePresenter stagePresenter, Action openRegisterView, IOption<User> userOption)
        {
            _view = view;
            _loginRepository = loginRepository;
            _stagePresenter = stagePresenter;
            _userOption = userOption;

            _view.OnLoginButtonClick = Login;
            _view.OnRegisterButtonClick = openRegisterView;
        }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async void Login()
        {
            var user = new User()
            {
                Username = _view.Username,
                Password = _view.Password
            };

            var (result, error) = await _loginRepository.Login(user);
            if (!result)
            {
                _view.Error = error;
                return;
            }
            _userOption.Value = user;

            _stagePresenter.CloseStage();
        }
    }
}
