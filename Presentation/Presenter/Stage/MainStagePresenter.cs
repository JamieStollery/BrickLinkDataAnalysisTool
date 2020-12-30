using Data.Common.Model;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private readonly IMainStageView _view;
        private readonly User _user;
        private readonly Func<ChildStageViewType, ChildStagePresenter> _stagePresenterFactory;

        public MainStagePresenter(IMainStageView view, User user, Func<ChildStageViewType, ChildStagePresenter> stagePresenterFactory) : base(view)
        {
            _view = view;
            _user = user;
            _stagePresenterFactory = stagePresenterFactory;

            _view.OnStageGotFocus = () => UpdateControls();
            _view.OnLogoutClick = () => Logout();
            _view.OnLoginClick = () => OpenLoginView();
            _view.OnRegisterClick = () => OpenRegisterView();
        }

        public void OpenLoginView() => _stagePresenterFactory(ChildStageViewType.Login).OpenStage();

        public void OpenRegisterView() => _stagePresenterFactory(ChildStageViewType.Register).OpenStage();

        public void OpenOrderView()
        {
            throw new NotImplementedException();
        }

        protected override void InitializeStage()        
        {
            // Initialize Stage
            OpenLoginView();
        }

        private void UpdateControls()
        {
            _view.Username = _user.Username;
            _view.LogoutEnabled = _user.IsLoggedIn;
            _view.LoginEnabled = !_user.IsLoggedIn;
            _view.RegisterEnabled = !_user.IsLoggedIn;
        }
        private void Logout()
        {
            _user.Invalidate();
            UpdateControls();
        }
    }
}
