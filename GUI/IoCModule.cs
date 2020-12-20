using Autofac;
using Autofac.Core;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Presenter.Login;
using Presentation.Presenter.Menu;
using Presentation.Presenter.Register;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;

namespace GUI
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register main View/Presenter keyed with StageKey.Main
            builder.RegisterType<MainStageView>().As<IStageView>().Keyed<IStageView>(StageKey.Main);
            builder.RegisterType<MainStagePresenter>().As<IStagePresenter>().Keyed<IStagePresenter>(StageKey.Main).WithParameter(ResolvedParameter.ForKeyed<IStageView>(StageKey.Main));

            // Register child View/Presenter keyed with StageKey.Child
            builder.RegisterType<ChildStageView>().As<IStageView>().Keyed<IStageView>(StageKey.Child);
            builder.RegisterType<ChildStagePresenter>().As<IStagePresenter>().Keyed<IStagePresenter>(StageKey.Child).WithParameter(ResolvedParameter.ForKeyed<IStageView>(StageKey.Child));

            // Register a stage Presenter factory that returns a child stage Presenter
            builder.Register<Func<ChildStageViewType, IStagePresenter>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return initialView => cc.ResolveKeyed<IStagePresenter>(StageKey.Child, TypedParameter.From(initialView));
            });

            // Register login View/Presenter
            builder.RegisterType<LoginView>().As<ILoginView>();
            builder.RegisterType<LoginPresenter>().As<ILoginPresenter>();

            // Register register View/Presenter
            builder.RegisterType<RegisterView>().As<IRegisterView>();
            builder.RegisterType<RegisterPresenter>().As<IRegisterPresenter>();

            // Register menu View/Presenter
            builder.RegisterType<MenuView>().As<IMenuView>();
            builder.RegisterType<MenuPresenter>().As<IMenuPresenter>();
        }
    }
}
