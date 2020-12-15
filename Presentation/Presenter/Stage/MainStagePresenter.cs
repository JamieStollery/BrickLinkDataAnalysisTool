using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class MainStagePresenter : StagePresenterBase
    {
        private Func<IStagePresenter> _stagePresenterFactory;

        public MainStagePresenter(IStageView view, Func<IStagePresenter> stagePresenterFactory) : base(view)
        {
            _stagePresenterFactory = stagePresenterFactory;
        }

        protected override void InitializeStage()
        {
            // Initialize Stage
        }
    }
}
