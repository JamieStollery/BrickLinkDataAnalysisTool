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

        public RegisterPresenter(IRegisterView view, ChildStagePresenter stagePresenter, IRegisterRepository registerRepository, User user)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _registerRepository = registerRepository;
            _user = user;

            _view.OnRegisterButtonClick = () => Register();
        }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async void Register()
        {
            _user.Username = _view.Username;
            _user.Password = _view.Password;
            _user.ConsumerKey = _view.ConsumerKey;
            _user.ConsumerSecret = _view.ConsumerSecret;
            _user.TokenValue = _view.TokenValue;
            _user.TokenSecret = _view.TokenSecret;

            var (result, error) = await _registerRepository.Register(_user);

            if(!result)
            {
                _user.Invalidate();
                _view.Error = error;
                return;
            }

            _stagePresenter.OpenLoginView();
        }
    }
}
