using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly Func<ChildStageViewType, IPresenter> _presenterFactory;

        public ChildStagePresenter(IStageView view, Func<ChildStageViewType, IPresenter> presenterFactory) : base(view)
        {
            _presenterFactory = presenterFactory;
        }

        public ChildStageViewType InitialView { private get; set; }

        public void OpenLoginView() => _presenterFactory(ChildStageViewType.Login).OpenView();

        public void OpenRegisterView() => _presenterFactory(ChildStageViewType.Register).OpenView();

        protected override void InitializeStage()
        {
            // Initialize Stage
            switch (InitialView)
            {
                case ChildStageViewType.Login:
                    OpenLoginView();
                    break;
                case ChildStageViewType.Register:
                    OpenRegisterView();
                    break;
            }
        }
    }
}
