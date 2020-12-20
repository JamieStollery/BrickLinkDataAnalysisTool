using Presentation.Presenter.Menu;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private readonly Func<ChildStageViewType, IStagePresenter> _stagePresenterFactory;
        private readonly IMenuPresenter _menuPresenter;

        public MainStagePresenter(IStageView view, IMenuPresenter menuPresenter, Func<ChildStageViewType, IStagePresenter> stagePresenterFactory) : base(view)
        {
            _stagePresenterFactory = stagePresenterFactory;
            _menuPresenter = menuPresenter;
            _menuPresenter.OpenLoginView = () => _stagePresenterFactory(ChildStageViewType.Login).OpenStage();
            _menuPresenter.OpenRegisterView = () => _stagePresenterFactory(ChildStageViewType.Register).OpenStage();
        }

        protected override void InitializeStage()        
        {
            // Initialize Stage
            View.AddView(_menuPresenter.View);
            _stagePresenterFactory(ChildStageViewType.Login).OpenStage();
        }
    }
}
