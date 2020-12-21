using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private readonly Func<ChildStageViewType, ChildStagePresenter> _stagePresenterFactory;
        private readonly Func<MenuPresenter> _menuPresenterFactory;

        public MainStagePresenter(IStageView view, Func<MenuPresenter> menuPresenterFactory, Func<ChildStageViewType, ChildStagePresenter> stagePresenterFactory) : base(view)
        {
            _stagePresenterFactory = stagePresenterFactory;
            _menuPresenterFactory = menuPresenterFactory;
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
            _menuPresenterFactory().OpenView();
            OpenLoginView();
        }
    }
}
