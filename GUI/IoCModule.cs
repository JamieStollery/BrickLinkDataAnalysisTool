using Autofac;
using Autofac.Core;
using Data.Common.Model;
using Data.IoC;
using FluentValidation;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Model;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Model.Orders;
using Presentation.Model.Validation;
using Presentation.Presenter;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;

namespace GUI
{
    public class IoCModule : Module
    {
        private enum Key
        {
            MainStage,
            ChildStage,
            Order,
            Login,
            Register
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<IoCDataModule>();

            // MainStage
            {
                // Register keyed main View/Presenter
                builder.RegisterType<MainStageView>().As<IMainStageView>().Keyed<IStageView>(Key.MainStage).InstancePerLifetimeScope();
                // Parameters must be specified because dependencies have multiple types registered
                builder.RegisterType<MainStagePresenter>()
                    .WithParameters(new[]{
                        // Resolve IStageView keyed with Key.Main
                        ResolvedParameter.ForKeyed<IMainStageView>(Key.MainStage),
                        // Resolve IPresenter factory keyed with PresenterType.Order
                        ResolvedParameter.ForKeyed<Func<IPresenter>>(Key.Order)
                    }).InstancePerLifetimeScope();
            }

            // ChildStage
            {
                // Register keyed child View/Presenter
                builder.RegisterType<ChildStageView>().As<IStageView>().Keyed<IStageView>(Key.ChildStage).InstancePerLifetimeScope();
                // Parameters must be specified because dependencies have multiple types registered
                builder.RegisterType<ChildStagePresenter>()
                    .WithParameters(new[]{
                        // Resolve IStageView keyed with Key.ChildStage
                        ResolvedParameter.ForKeyed<IStageView>(Key.ChildStage),
                        // Resolve IPresenter factory keyed with PresenterType.Login
                        // Parameter name must be specified as ChildStagePresenter takes 2 different IPresenter factories
                        new ResolvedParameter(
                            (pi, ctx) => pi.ParameterType == typeof(Func<IPresenter>) && pi.Name == "loginPresenterFactory",
                            (pi, ctx) => ctx.ResolveKeyed<Func<IPresenter>>(Key.Login)
                        ),
                        // Resolve IPresenter factory keyed with PresenterType.Register
                        // Parameter name must be specified as ChildStagePresenter takes 2 different IPresenter factories
                        new ResolvedParameter(
                            (pi, ctx) => pi.ParameterType == typeof(Func<IPresenter>) && pi.Name == "registerPresenterFactory",
                            (pi, ctx) => ctx.ResolveKeyed<Func<IPresenter>>(Key.Register)
                        )
                    }).InstancePerLifetimeScope();
                // Register a ChildStagePresenter factory that returns a child stage Presenter with the InitialView property set
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
            }

            // Order
            {
                // Register order View/Presenter keyed with PresenterType.Order
                builder.RegisterType<OrderView>().As<IOrderView>();
                builder.RegisterType<OrderPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Order);
                // Register IPresenter factory which returns IPresenter keyed with PresenterType.Order
                builder.Register<Func<IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return () => cc.ResolveKeyed<IPresenter>(Key.Order);
                }).Keyed<Func<IPresenter>>(Key.Order);
            }

            // Item
            {
                // Register item View/Presenter
                builder.RegisterType<ItemPresenter>();
                builder.RegisterType<ItemView>().As<IItemView>();
                // Register ItemPresenter factory
                builder.Register<Func<IReadOnlyList<Item>, ItemPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return items => cc.Resolve<ItemPresenter>(TypedParameter.From(items));
                });
            }

            // Login
            {
                // Register login View/Presenter keyed with PresenterType.Login
                builder.RegisterType<LoginView>().As<ILoginView>();
                // Parameter must be specified because IValidator<User> has multiple types registered
                builder.RegisterType<LoginPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Login).WithParameter(ResolvedParameter.ForKeyed<IValidator<User>>(UserValidationType.Login));
                // Register IPresenter factory which returns IPresenter keyed with PresenterType.Login
                builder.Register<Func<IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return () => cc.ResolveKeyed<IPresenter>(Key.Login);
                }).Keyed<Func<IPresenter>>(Key.Login);
            }

            // Register
            {
                // Register register View/Presenter keyed with PresenterType.Register
                builder.RegisterType<RegisterView>().As<IRegisterView>();
                // Parameter must be specified because IValidator<User> has multiple types registered
                builder.RegisterType<RegisterPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Register).WithParameter(ResolvedParameter.ForKeyed<IValidator<User>>(UserValidationType.Register));
                // Register IPresenter factory which returns IPresenter keyed with PresenterType.Register
                builder.Register<Func<IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return () => cc.ResolveKeyed<IPresenter>(Key.Register);
                }).Keyed<Func<IPresenter>>(Key.Register);
            }

            // Validators
            {
                builder.RegisterType<LoginUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Login).InstancePerLifetimeScope();
                builder.RegisterType<RegisterUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Register).InstancePerLifetimeScope();
            }

            // Mappers
            {
                builder.RegisterType<DtoMapper>().As<IDtoMapper>().InstancePerLifetimeScope();
                builder.RegisterType<VmMapper>().As<IVmMapper>().InstancePerLifetimeScope();
            }

            // Any/All filter strategies
            {
                builder.RegisterType<FilterAnyStrategy>().As<IAnyAllFilterModeStrategy>().Keyed<IAnyAllFilterModeStrategy>(AnyAllFilterMode.Any).InstancePerLifetimeScope();
                builder.RegisterType<FilterAllStrategy>().As<IAnyAllFilterModeStrategy>().Keyed<IAnyAllFilterModeStrategy>(AnyAllFilterMode.All).InstancePerLifetimeScope();
                // Register an IAnyAllFilterModeStrategy factory which returns the strategy keyed with the AnyAllFilterMode provided
                builder.Register<Func<AnyAllFilterMode, IAnyAllFilterModeStrategy>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return mode => cc.ResolveKeyed<IAnyAllFilterModeStrategy>(mode);
                });
            }

            // Min/Max filter strategies
            {
                builder.RegisterType<ItemCountFilterMaxStrategy>().As<IMinMaxFilterModeStrategy>().Keyed<IMinMaxFilterModeStrategy>(MinMaxFilterMode.Max);
                builder.RegisterType<ItemCountFilterMinStrategy>().As<IMinMaxFilterModeStrategy>().Keyed<IMinMaxFilterModeStrategy>(MinMaxFilterMode.Min);
                // Register an IMinMaxFilterModeStrategy factory which returns the strategy keyed with the MinMaxFilterMode provided
                builder.Register<Func<ItemCountType, MinMaxFilterMode, IMinMaxFilterModeStrategy>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return (countType, mode) => {
                        Func<Order, int> func = (Order order) => countType == ItemCountType.Total ? order.TotalCount : order.UniqueCount;
                        return cc.ResolveKeyed<IMinMaxFilterModeStrategy>(mode, TypedParameter.From(func));
                    };
                });
            }
        }
    }
}
