using Autofac;
using Autofac.Core;
using Data.Common;
using Data.IoC;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Presenter;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;

namespace GUI
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<IoCDataModule>();
            builder.RegisterType<User>().SingleInstance();

            // Register main View/Presenter keyed with StageKey.Main
            builder.RegisterType<MainStageView>().As<IMainStageView>().Keyed<IStageView>(StageKey.Main).InstancePerLifetimeScope();
            builder.RegisterType<MainStagePresenter>().WithParameter(ResolvedParameter.ForKeyed<IMainStageView>(StageKey.Main)).InstancePerLifetimeScope();

            // Register child View/Presenter keyed with StageKey.Child
            builder.RegisterType<ChildStageView>().As<IStageView>().Keyed<IStageView>(StageKey.Child).InstancePerLifetimeScope();
            builder.RegisterType<ChildStagePresenter>().WithParameter(ResolvedParameter.ForKeyed<IStageView>(StageKey.Child)).InstancePerLifetimeScope();

            // Register a child stage Presenter factory that returns a child stage Presenter with the InitialView property set
            builder.Register<Func<ChildStageViewType, ChildStagePresenter>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return initialView =>
                {
                    var presenter = cc.Resolve<ChildStagePresenter>();
                    presenter.InitialView = initialView;
                    return presenter;
                };
            });

            // Register login View/Presenter
            builder.RegisterType<LoginView>().As<ILoginView>();
            builder.RegisterType<LoginPresenter>();

            // Register register View/Presenter
            builder.RegisterType<RegisterView>().As<IRegisterView>();
            builder.RegisterType<RegisterPresenter>();

        }
    }
}
