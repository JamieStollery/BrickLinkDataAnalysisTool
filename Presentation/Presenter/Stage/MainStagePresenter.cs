﻿using Data.Common;
using Data.Common.Model;
using Data.Common.Option;
using Data.LocalDB;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private readonly IMainStageView _view;
        private readonly IOption<User> _userOption;
        private readonly IOption<DataMode> _dataModeOption;
        private readonly Func<ChildStageViewType, IStagePresenter> _stagePresenterFactory;
        private readonly Func<IPresenter> _orderPresenterFactory;
        private readonly IDatabaseUpdater _databaseUpdater;
        private readonly IDatabaseInitializer _databaseInitializer; 

        public MainStagePresenter(IMainStageView view, Func<ChildStageViewType, Action, IStagePresenter> stagePresenterFactory, Func<IPresenter> orderPresenterFactory,
            IDatabaseUpdater databaseUpdater, IDatabaseInitializer databaseInitializer, IOption<DataMode> dataModeOption, IOption<User> userOption) : base(view)
        {
            _view = view;
            _stagePresenterFactory = (viewType) => stagePresenterFactory(viewType, UpdateStage);
            _orderPresenterFactory = orderPresenterFactory;
            _databaseUpdater = databaseUpdater;
            _databaseInitializer = databaseInitializer;
            _dataModeOption = dataModeOption;
            _userOption = userOption;

            _view.OnLogoutClick = Logout;
            _view.OnLoginClick = OpenLoginView;
            _view.OnRegisterClick = OpenRegisterView;
            _view.OnChangeDataModeClick = ChangeDataMode;
            _view.OnUpdateDatabaseClick = UpdateDatabase;
            _view.OnClearDatabaseClick = ClearDatabase;
        }

        public void OpenLoginView() => _stagePresenterFactory(ChildStageViewType.Login).OpenStage();

        public void OpenRegisterView() => _stagePresenterFactory(ChildStageViewType.Register).OpenStage();

        public void OpenOrderView() => _orderPresenterFactory().OpenView();

        protected override async void InitializeStage()
        {
            await _databaseInitializer.CreateTables();

            if (_userOption.Value is null)
            {
                OpenLoginView();
            }
            else
            {
                UpdateStage();
            }
        }

        private void UpdateControls()
        {
            _view.Username = _userOption.Value?.Username;
            _view.DataMode = _dataModeOption.Value.ToString();
            _view.DatabaseControlsEnabled = !(_userOption.Value is null);
            _view.LogoutEnabled = !(_userOption.Value is null);
            _view.LoginEnabled = _userOption.Value is null;
            _view.RegisterEnabled = _userOption.Value is null;
        }

        private void Logout()
        {
            _userOption.ResetValue();
            _dataModeOption.ResetValue();

            UpdateControls();
            CloseCurrentView();
        }

        private void UpdateStage()
        {
            UpdateControls();
            if (!(_userOption.Value is null))
            {
                OpenOrderView();
            }
        }

        private void ChangeDataMode()
        {
            _dataModeOption.Value = _dataModeOption.Value switch
            {
                DataMode.Database => DataMode.API,
                DataMode.API => DataMode.Database,
                _ => throw new ArgumentException()
            };
            _view.DataMode = _dataModeOption.Value.ToString();
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

        private async void ClearDatabase()
        {
            await _databaseUpdater.ClearDatabase();
        }
    }
}
