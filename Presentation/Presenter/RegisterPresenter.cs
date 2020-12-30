using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.LocalDB;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System.Linq;

namespace Presentation.Presenter
{
    public class RegisterPresenter : PresenterBase<IRegisterView, ChildStagePresenter>
    {
        private readonly RegisterRepository _registerRepository;
        private readonly User _user;

        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter, RegisterRepository registerRepository, User user) : base(view, stagePresenter)
        {
            _registerRepository = registerRepository;
            _user = user;

            View.OnRegisterButtonClick = () => Register();
        }

        private async void Register()
        {
            // Register

            _user.Username = View.Username;
            _user.Password = View.Password;
            _user.ConsumerKey = View.ConsumerKey;
            _user.ConsumerSecret = View.ConsumerSecret;
            _user.TokenValue = View.TokenValue;
            _user.TokenSecret = View.TokenSecret;

            var result = _user.Validate(UserValidationType.Register);
            if(!result.IsValid)
            {
                _user.Invalidate();
                View.Error = result.Errors.First().ErrorMessage;
                return;
            }
            if(!await _registerRepository.Register(_user))
            {
                _user.Invalidate();
                View.Error = "Failed to create user";
                return;
            }

            //await _registerRepository.Register();
            StagePresenter.CloseView(View);
            StagePresenter.OpenLoginView();
        }
    }
}
