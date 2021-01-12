using Autofac;
using Autofac.Core;
using Data.Common.Model;
using Data.IoC;
using FluentValidation;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Filtering;
using Presentation.Model.Validation;
using Presentation.Presenter;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Filtering.AnyAll;
using Presentation.Model;
using Presentation.Filtering.MinMax;
using Presentation.Model.Orders;

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

            // Register any/all filter mode strategies
            builder.RegisterType<FilterAnyStrategy>().As<IAnyAllFilterModeStrategy>().Keyed<IAnyAllFilterModeStrategy>(AnyAllFilterMode.Any).InstancePerLifetimeScope();
            builder.RegisterType<FilterAllStrategy>().As<IAnyAllFilterModeStrategy>().Keyed<IAnyAllFilterModeStrategy>(AnyAllFilterMode.All).InstancePerLifetimeScope();
            builder.Register<Func<AnyAllFilterMode, IAnyAllFilterModeStrategy>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return mode => cc.ResolveKeyed<IAnyAllFilterModeStrategy>(mode);
            });

            // Register min/max filter mode strategies
            builder.RegisterType<ItemCountFilterMaxStrategy>().As<IMinMaxFilterModeStrategy>().Keyed<IMinMaxFilterModeStrategy>(MinMaxFilterMode.Max);
            builder.RegisterType<ItemCountFilterMinStrategy>().As<IMinMaxFilterModeStrategy>().Keyed<IMinMaxFilterModeStrategy>(MinMaxFilterMode.Min);
            builder.Register<Func<ItemCountType, MinMaxFilterMode, IMinMaxFilterModeStrategy>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return (countType, mode) => {
                    int func(Order order) => countType == ItemCountType.Total ? order.TotalCount : order.UniqueCount;
                    return cc.ResolveKeyed<IMinMaxFilterModeStrategy>(mode, TypedParameter.From((Func<Order, int>)func));
                };
            });
          
            builder.RegisterType<LoginUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Login).InstancePerLifetimeScope();
            builder.RegisterType<RegisterUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Register).InstancePerLifetimeScope();
            builder.Register<Func<UserValidationType, IValidator<User>>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return validationType => cc.ResolveKeyed<IValidator<User>>(validationType);
            });

            builder.RegisterType<DtoMapper>().As<IDtoMapper>().InstancePerLifetimeScope();

        }
    }
}
