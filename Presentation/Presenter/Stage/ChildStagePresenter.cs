using Presentation.View.Interface;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        public ChildStagePresenter(IStageView view) : base(view) { }

        protected override void InitializeStage()
        {
            // Initialize Stage
        }
    }
}
