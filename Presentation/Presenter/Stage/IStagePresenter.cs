using Presentation.View.Interface;

namespace Presentation.Presenter.Stage
{
    public interface IStagePresenter
    {
        void CloseStage();
        void OpenStage();
        void OpenView(IView view);
    }
}