using Presentation.View.Interface;

namespace Presentation.Presenter.Stage
{
    public abstract class StagePresenterBase
    {
        private readonly IStageView _view;

        protected StagePresenterBase(IStageView view)
        {
            _view = view;
            _view.OnOpened = () => InitializeStage();
        }

        public void OpenStage() => _view.OpenStage();

        public void CloseStage() => _view.CloseStage();

        public void CloseView(IView view) => _view.RemoveView(view);

        public void OpenView(IView view) => _view.AddView(view);

        protected abstract void InitializeStage();
    }
}
