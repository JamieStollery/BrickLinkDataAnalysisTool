using Autofac;
using Autofac.Core;
using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.IoC;
using FluentValidation;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Filtering;
using Presentation.Presenter;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;

namespace GUI
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<IoCDataModule>();

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

            // Register login View/Presenter keyed with ChildStageViewType.Login
            builder.RegisterType<LoginView>().As<ILoginView>();
            builder.RegisterType<LoginPresenter>().As<IPresenter>().Keyed<IPresenter>(ChildStageViewType.Login);

            // Register register View/Presenter keyed with ChildStageViewType.Register
            builder.RegisterType<RegisterView>().As<IRegisterView>();
            builder.RegisterType<RegisterPresenter>().As<IPresenter>().Keyed<IPresenter>(ChildStageViewType.Register);

            // Register an IPresenter factory that returns an IPresenter associated to the ChildStageViewType key
            builder.Register<Func<ChildStageViewType, IPresenter>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return viewType => cc.ResolveKeyed<IPresenter>(viewType);
            });

            builder.RegisterType<OrderPresenter>();
            builder.RegisterType<OrderView>().As<IOrderView>();
            builder.RegisterType<ItemView>().As<IItemView>();
            builder.Register<Func<IReadOnlyList<Item>, IItemView>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return items => cc.Resolve<IItemView>(TypedParameter.From<IReadOnlyList<object>>(items));
            });

            builder.RegisterType<FilterAnyStrategy>().As<IFilterModeStrategy>().Keyed<IFilterModeStrategy>(FilterMode.Any).InstancePerLifetimeScope();
            builder.RegisterType<FilterAllStrategy>().As<IFilterModeStrategy>().Keyed<IFilterModeStrategy>(FilterMode.All).InstancePerLifetimeScope();
            builder.Register<Func<FilterMode, IFilterModeStrategy>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return mode => cc.ResolveKeyed<IFilterModeStrategy>(mode);
            });
        }
    }
}
