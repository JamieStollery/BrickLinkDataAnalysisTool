using Presentation.Presenter.Stage;
using Presentation.View.Interface;

namespace Presentation.Presenter
{
    public abstract class PresenterBase<TView, TStagePresenter> 
        where TView : IView 
        where TStagePresenter : StagePresenterBase
    {
        protected PresenterBase(TView view, TStagePresenter stagePresenter)
        {
            View = view;
            StagePresenter = stagePresenter;
        }

        protected TView View { get; }
        protected TStagePresenter StagePresenter { get; }

        public void OpenView() => StagePresenter.OpenView(View);
    }
}
