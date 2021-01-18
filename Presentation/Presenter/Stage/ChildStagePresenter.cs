using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly IStageView _view;
        private readonly Func<IPresenter> _loginPresenterFactory;
        private readonly Func<IPresenter> _registerPresenterFactory;

        public ChildStagePresenter(IStageView view, Func<IPresenter> loginPresenterFactory, Func<IPresenter> registerPresenterFactory) : base(view)
        {
            _view = view;
            _loginPresenterFactory = loginPresenterFactory;
            _registerPresenterFactory = registerPresenterFactory;
        }

        public ChildStageViewType InitialView { private get; set; }
        public Action OnStageClosed { set => _view.OnStageClosed = value; }

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
