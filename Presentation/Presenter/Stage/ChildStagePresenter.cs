using Presentation.Presenter.Login;
using Presentation.Presenter.Register;
using Presentation.View.Interface;
using System;

namespace Presentation.Presenter.Stage
{
    public class ChildStagePresenter : StagePresenterBase
    {
        private readonly Func<ILoginPresenter> _loginPresenterFactory;
        private readonly Func<IRegisterPresenter> _registerPresenterFactory;

        public ChildStagePresenter(IStageView view, Func<ILoginPresenter> loginPresenterFactory, Func<IRegisterPresenter> registerPresenterFactory) : base(view)
        {
            _loginPresenterFactory = loginPresenterFactory;
            _registerPresenterFactory = registerPresenterFactory;
        }

        protected override void InitializeStage()
        {
            // Initialize Stage
            OpenLoginView();
        }

        private void OpenLoginView()
        {
            var presenter = CreateLoginPresenter();
            View.AddView(presenter.View);
        }

        private void OpenRegisterView()
        {
            var presenter = CreateRegisterPresenter();
            View.AddView(presenter.View);
        }

        private ILoginPresenter CreateLoginPresenter()
        {
            var presenter = _loginPresenterFactory();
            presenter.CloseView = (view) => View.RemoveView(view);
            presenter.OpenRegisterView = () => OpenRegisterView();
            presenter.CloseStage = () => CloseStage();
            return presenter;
        }

        private IRegisterPresenter CreateRegisterPresenter()
        {
            var presenter = _registerPresenterFactory();
            presenter.CloseView = (view) => View.RemoveView(view);
            presenter.OpenLoginView = () => OpenLoginView();
            return presenter;
        }
    }
}
