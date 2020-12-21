using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly Func<LoginPresenter> _loginPresenterFactory;
        private readonly Func<RegisterPresenter> _registerPresenterFactory;

        public ChildStagePresenter(IStageView view, Func<LoginPresenter> loginPresenterFactory, Func<RegisterPresenter> registerPresenterFactory) : base(view)
        {
            _loginPresenterFactory = loginPresenterFactory;
            _registerPresenterFactory = registerPresenterFactory;
        }

        public ChildStageViewType InitialView { private get; set; }

        public void OpenLoginView() => _loginPresenterFactory().OpenView();

        public void OpenRegisterView() => _registerPresenterFactory().OpenView();

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
