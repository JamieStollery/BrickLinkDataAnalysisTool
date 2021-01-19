using Data.Common;
using Data.Common.Model;
using Presentation.View.Interface;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private readonly IMainStageView _view;
        private readonly User _user;
        private readonly Func<ChildStageViewType, ChildStagePresenter> _stagePresenterFactory;
        private readonly Func<IPresenter> _orderPresenterFactory;
        private readonly IDatabaseUpdater _databaseUpdater;

        public MainStagePresenter(IMainStageView view, User user, Func<ChildStageViewType, ChildStagePresenter> stagePresenterFactory, Func<IPresenter> orderPresenterFactory, IDatabaseUpdater databaseUpdater) : base(view)
        {
            _view = view;
            _user = user;
            _stagePresenterFactory = (viewType) =>
            {
                var childStagePresenter = stagePresenterFactory(viewType);
                childStagePresenter.OnStageClosed = UpdateStage;
                return childStagePresenter;
            };
            _orderPresenterFactory = orderPresenterFactory;
            _databaseUpdater = databaseUpdater;

            _view.OnLogoutClick = Logout;
            _view.OnLoginClick = OpenLoginView;
            _view.OnRegisterClick = OpenRegisterView;
            _view.OnChangeDataModeClick = ChangeDataMode;
            _view.OnUpdateDatabaseClick = UpdateDatabase;
            _view.OnClearDatabaseClick = ClearDatabase;

            DataMode = DataMode.Database;
        }

        public DataMode DataMode { get; private set; }

        public void OpenLoginView() => _stagePresenterFactory(ChildStageViewType.Login).OpenStage();

        public void OpenRegisterView() => _stagePresenterFactory(ChildStageViewType.Register).OpenStage();

        public void OpenOrderView() => _orderPresenterFactory().OpenView();

        protected override void InitializeStage()
        {
            //OpenLoginView();
            _user.Username = "JamieStollery";
            _user.Password = "test";
            _user.ConsumerKey = "F79394C3989A4A35A94B4ECC82B1B08C";
            _user.ConsumerSecret = "AD2C9F5A38584B68A38F2EEE7AF35E62";
            _user.TokenValue = "594B505FC34B427EBB22AE05843C969E";
            _user.TokenSecret = "CD49808C7FC442AF8EB303317ADABDAF";

            UpdateStage();
        }

        private void UpdateControls()
        {
            _view.Username = _user.Username;
            _view.DataMode = DataMode.ToString();
            _view.DatabaseControlsEnabled = _user.IsLoggedIn;
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

        private void ChangeDataMode()
        {
            switch (DataMode)
            {
                case DataMode.Database:
                    DataMode = DataMode.API;
                    break;
                case DataMode.API:
                    DataMode = DataMode.Database;
                    break;
            }
            _view.DataMode = DataMode.ToString();
        }

        private async void UpdateDatabase()
        {
            var response = await _databaseUpdater.UpdateDatabase();
            _view.ProgressBarLength = response.count;
            _view.Status = "Updating Database";

            await foreach (var task in response.tasks)
            {
                _view.ProgressBarProgress += 1;
            }
            _view.ProgressBarProgress = 0;
            _view.Status = string.Empty;
        }

        private void ClearDatabase()
        {

        }
    }
}
