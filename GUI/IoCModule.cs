using Autofac;
using Autofac.Core;
using GUI.View.Stage;
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
            builder.Register<Func<IStagePresenter>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return () => cc.ResolveKeyed<IStagePresenter>(StageKey.Child);
            });
        }
    }
}
