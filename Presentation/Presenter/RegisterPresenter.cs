using Data.Common.Model;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter
{
    public class RegisterPresenter : IPresenter
    {
        private readonly IRegisterView _view; 
        private readonly IRegisterRepository _registerRepository;
        private readonly IStagePresenter _stagePresenter;
        private readonly Action _openLoginView;
        private readonly IOption<User> _userOption;

        public RegisterPresenter(IRegisterView view, IRegisterRepository registerRepository, IStagePresenter stagePresenter, Action openLoginView, IOption<User> userOption)
        {
            _view = view;
            _registerRepository = registerRepository;
            _stagePresenter = stagePresenter;
            _openLoginView = openLoginView;
            _userOption = userOption;

            _view.OnRegisterButtonClick = Register;
        }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async void Register()
        {
            var user = new User()
            {
                Username = _view.Username,
                Password = _view.Password,
                ConsumerKey = _view.ConsumerKey,
                ConsumerSecret = _view.ConsumerSecret,
                TokenValue = _view.TokenValue,
                TokenSecret = _view.TokenSecret
            };

            var (result, error) = await _registerRepository.Register(user);

            if(!result)
            {
                _view.Error = error;
                return;
            }
            _userOption.Value = user;

            _openLoginView();
        }
    }
}
