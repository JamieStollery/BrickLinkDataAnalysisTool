using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly Func<Action, IPresenter> _loginPresenterFactory;
        private readonly Func<Action, IPresenter> _registerPresenterFactory;

        public ChildStagePresenter(IStageView view, Func<Action, IPresenter> loginPresenterFactory, Func<Action, IPresenter> registerPresenterFactory, Action updateMainStage) : base(view)
        {
            _loginPresenterFactory = loginPresenterFactory;
            _registerPresenterFactory = registerPresenterFactory;
            view.OnStageClosed = updateMainStage;
        }

        public ChildStageViewType InitialView { private get; set; }

        public void OpenLoginView() => _loginPresenterFactory(OpenRegisterView).OpenView();

        public void OpenRegisterView() => _registerPresenterFactory(OpenLoginView).OpenView();

        protected override void InitializeStage()
        {
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
