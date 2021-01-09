using Data.Common;
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
        private readonly Func<OrderPresenter> _orderPresenterFactory;

        public MainStagePresenter(IMainStageView view, User user, Func<ChildStageViewType, ChildStagePresenter> stagePresenterFactory, Func<OrderPresenter> orderPresenterFactory) : base(view)
        {
            _view = view;
            _user = user;
            _stagePresenterFactory = (viewType) =>
            {
                var childStagePresenter = stagePresenterFactory(viewType);
                childStagePresenter.OnStageClosed = () => UpdateStage();
                return childStagePresenter;
            };
            _orderPresenterFactory = orderPresenterFactory;

            _view.OnLogoutClick = () => Logout();
            _view.OnLoginClick = () => OpenLoginView();
            _view.OnRegisterClick = () => OpenRegisterView();

            DataMode = DataMode.API;
        }

        public DataMode DataMode { get; private set; }

        public void OpenLoginView() => _stagePresenterFactory(ChildStageViewType.Login).OpenStage();

        public void OpenRegisterView() => _stagePresenterFactory(ChildStageViewType.Register).OpenStage();

        public void OpenOrderView() => _orderPresenterFactory().OpenOrderView();

        protected override void InitializeStage() => OpenLoginView();

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
            CloseCurrentView();
        }
        private void UpdateStage()
        {
            UpdateControls();
            if (_user.IsLoggedIn) OpenOrderView();
        }
    }
}
