using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private Func<ChildStageViewType, IStagePresenter> _stagePresenterFactory;

        public MainStagePresenter(IStageView view, Func<ChildStageViewType, IStagePresenter> stagePresenterFactory) : base(view)
        {
            _stagePresenterFactory = stagePresenterFactory;
        }

        protected override void InitializeStage()
        {
            // Initialize Stage
            _stagePresenterFactory(ChildStageViewType.Login).OpenStage();
        }
    }
}
