using System;

namespace Presentation.View.Interface
{
    public interface IStageView
    {
        Action OnStageOpened { set; }
        Action OnStageClosed { set; }
        void OpenStage();
        void CloseStage();
        void AddView(IView view);
        void RemoveView(IView view);
    }
}
