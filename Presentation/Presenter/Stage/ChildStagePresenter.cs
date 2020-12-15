using Presentation.Presenter.Login;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly Func<ILoginPresenter> _loginPresenterFactory;

        public ChildStagePresenter(IStageView view, Func<ILoginPresenter> loginPresenterFactory) : base(view)
        {
            _loginPresenterFactory = loginPresenterFactory;
        }

        protected override void InitializeStage()
        {
            // Initialize Stage
            var loginPresenter = CreateLoginPresenter();
            View.AddView(loginPresenter.View);
        }

        private ILoginPresenter CreateLoginPresenter()
        {
            var loginPresenter = _loginPresenterFactory();
            loginPresenter.CloseStage = () => CloseStage();
            return loginPresenter;
        }
    }
}
