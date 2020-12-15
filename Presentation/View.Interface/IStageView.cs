using System;

namespace Presentation.View.Interface
{
    public interface IStageView
    {
        Action OnOpened { set; }
        void OpenStage();
        void CloseStage();
        void AddView(IView view);
        void RemoveView(IView view);
    }
}
