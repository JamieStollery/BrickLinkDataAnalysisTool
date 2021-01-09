using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class RegisterPresenter : IPresenter
    {
        private readonly IRegisterView _view; 
        private readonly ChildStagePresenter _stagePresenter;
        private readonly RegisterRepository _registerRepository;
        private readonly User _user;

        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter, RegisterRepository registerRepository, User user)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _registerRepository = registerRepository;
            _user = user;

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

            var result = _user.Validate(UserValidationType.Register);
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
