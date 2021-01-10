using Data.Common.Model;
using Data.Common.Repository.Interface;
using FluentValidation;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class RegisterPresenter : IPresenter
    {
        private readonly IRegisterView _view; 
        private readonly ChildStagePresenter _stagePresenter;
        private readonly IRegisterRepository _registerRepository;
        private readonly User _user;
        private readonly IValidator<User> _userValidator;

        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter, IRegisterRepository registerRepository, User user, IValidator<User> userValidator)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _registerRepository = registerRepository;
            _user = user;
            _userValidator = userValidator;

            _view.OnRegisterButtonClick = () => Register();
        }

        public void OpenOrderView() => _stagePresenter.OpenView(_view);

        private async void Register()
        {
            // Register

            _user.Username = _view.Username;
            _user.Password = _view.Password;
            _user.ConsumerKey = _view.ConsumerKey;
            _user.ConsumerSecret = _view.ConsumerSecret;
            _user.TokenValue = _view.TokenValue;
            _user.TokenSecret = _view.TokenSecret;

            var result = _userValidator.Validate(_user);

            if(!result.IsValid)
            {
                _user.Invalidate();
                _view.Error = result.Errors.First().ErrorMessage;
                return;
            }
            if(!await _registerRepository.Register(_user))
            {
                _user.Invalidate();
                _view.Error = "Failed to create user";
                return;
            }

            //await _registerRepository.Register();
            _stagePresenter.OpenLoginView();
        }
    }
}
