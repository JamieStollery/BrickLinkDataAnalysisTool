using Presentation.View.Interface;

namespace Presentation.Presenter.Stage
{
    public abstract class StagePresenterBase
    {
        private readonly IStageView _view;
        private IView _currentView;

        protected StagePresenterBase(IStageView view)
        {
            _view = view;
            _view.OnStageOpened = () => InitializeStage();
        }

        public void OpenStage() => _view.OpenStage();

        public void CloseStage() => _view.CloseStage();

        public void OpenView(IView view)
        {
            if (_currentView != null) CloseCurrentView();
            _view.AddView(view);
            _currentView = view;
        }

        protected void CloseCurrentView() => _view.RemoveView(_currentView);

        protected abstract void InitializeStage();
    }
}
