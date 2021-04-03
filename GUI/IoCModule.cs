using Autofac;
using Autofac.Core;
using Data.IoC;
using GUI.View;
using GUI.View.Stage;
using Presentation;
using Presentation.Filtering;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Model.Orders;
using Presentation.Presenter;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<IoCDataModule>();

            // MainStage
            {
                // Register keyed main View/Presenter
                builder.RegisterType<MainStageView>().As<IMainStageView>().Keyed<IStageView>(Key.MainStage).InstancePerLifetimeScope();
                // Parameters must be specified because dependencies have multiple types registered
                builder.RegisterType<MainStagePresenter>().As<IStagePresenter>().Keyed<IStagePresenter>(Key.MainStage)
                    .WithParameters(new[]{
                        // Resolve IStageView keyed with Key.Main
                        ResolvedParameter.ForKeyed<IMainStageView>(Key.MainStage),
                        // Resolve IPresenter factory keyed with PresenterType.Order
                        ResolvedParameter.ForKeyed<Func<IPresenter>>(Key.Order)
                    }).InstancePerLifetimeScope();
                // Register ToolStripRenderer for MainStageView
                builder.RegisterInstance(new ToolStripProfessionalRenderer(new MenuColorTable())).As<ToolStripRenderer>();
            }

            // ChildStage
            {
                // Register keyed child View/Presenter
                builder.RegisterType<ChildStageView>().As<IStageView>().Keyed<IStageView>(Key.ChildStage).InstancePerLifetimeScope();
                // Parameters must be specified because dependencies have multiple types registered
                builder.RegisterType<ChildStagePresenter>().As<IStagePresenter>().AsSelf().Keyed<IStagePresenter>(Key.ChildStage)
                    .WithParameters(new[]{
                        // Resolve IStageView keyed with Key.ChildStage
                        ResolvedParameter.ForKeyed<IStageView>(Key.ChildStage),
                        // Resolve IPresenter factory keyed with PresenterType.Login
                        // Parameter name must be specified as ChildStagePresenter takes 2 different IPresenter factories
                        new ResolvedParameter(
                            (pi, ctx) => pi.ParameterType == typeof(Func<Action, IPresenter>) && pi.Name == "loginPresenterFactory",
                            (pi, ctx) => ctx.ResolveKeyed<Func<Action, IPresenter>>(Key.Login)
                        ),
                        // Resolve IPresenter factory keyed with PresenterType.Register
                        // Parameter name must be specified as ChildStagePresenter takes 2 different IPresenter factories
                        new ResolvedParameter(
                            (pi, ctx) => pi.ParameterType == typeof(Func<Action, IPresenter>) && pi.Name == "registerPresenterFactory",
                            (pi, ctx) => ctx.ResolveKeyed<Func<Action, IPresenter>>(Key.Register)
                        )
                    }).InstancePerLifetimeScope();
                // Register an IStagePresenter factory that returns a child stage Presenter with the InitialView property set
                builder.Register<Func<ChildStageViewType, Action, ChildStagePresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return (initialView, action) =>
                    {
                        var presenter = cc.Resolve<ChildStagePresenter>(TypedParameter.From(action));
                        presenter.InitialView = initialView;
                        return presenter;
                    };
                });
            }

            // Order
            {
                // Register order View/Presenter keyed with PresenterType.Order
                builder.RegisterType<OrderView>().As<IOrderView>();
                builder.RegisterType<OrderPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Order).WithParameter(ResolvedParameter.ForKeyed<IStagePresenter>(Key.MainStage));
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
                builder.RegisterType<ItemView>().As<IItemView>();
                builder.RegisterType<ItemPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Item).WithParameter(ResolvedParameter.ForKeyed<IStagePresenter>(Key.MainStage));
                // Register ItemPresenter factory
                builder.Register<Func<IReadOnlyList<Item>, Action, IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return (items, action) => cc.ResolveKeyed<IPresenter>(Key.Item, TypedParameter.From(items), TypedParameter.From(action));
                });
            }

            // Login
            {
                // Register login View/Presenter keyed with PresenterType.Login
                builder.RegisterType<LoginView>().As<ILoginView>();
                builder.RegisterType<LoginPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Login).WithParameter(ResolvedParameter.ForKeyed<IStagePresenter>(Key.ChildStage));
                // Register IPresenter factory which returns IPresenter keyed with PresenterType.Login
                builder.Register<Func<Action, IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return action => cc.ResolveKeyed<IPresenter>(Key.Login, TypedParameter.From(action));
                }).Keyed<Func<Action, IPresenter>>(Key.Login);
            }

            // Register
            {
                // Register register View/Presenter keyed with PresenterType.Register
                builder.RegisterType<RegisterView>().As<IRegisterView>();
                builder.RegisterType<RegisterPresenter>().As<IPresenter>().Keyed<IPresenter>(Key.Register).WithParameter(ResolvedParameter.ForKeyed<IStagePresenter>(Key.ChildStage));
                // Register IPresenter factory which returns IPresenter keyed with PresenterType.Register
                builder.Register<Func<Action, IPresenter>>(context =>
                {
                    var cc = context.Resolve<IComponentContext>();
                    return action => cc.ResolveKeyed<IPresenter>(Key.Register, TypedParameter.From(action));
                }).Keyed<Func<Action, IPresenter>>(Key.Register);
            }

            // Mappers
            {
                builder.RegisterType<DtoMapper>().As<IDtoMapper>().InstancePerLifetimeScope();
                builder.RegisterType<VmMapper>().As<IVmMapper>().InstancePerLifetimeScope();
            }

            // Filtering
            {
                builder.RegisterType<OrderFilterer>().As<IOrderFilterer>().InstancePerLifetimeScope();
                builder.RegisterType<ItemFilterer>().As<IItemFilterer>().InstancePerLifetimeScope();

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
                    builder.RegisterType<OrderItemCountFilterMaxStrategy>().As<IMinMaxFilterModeStrategy<Order>>().Keyed<IMinMaxFilterModeStrategy<Order>>(MinMaxFilterMode.Max);
                    builder.RegisterType<OrderItemCountFilterMinStrategy>().As<IMinMaxFilterModeStrategy<Order>>().Keyed<IMinMaxFilterModeStrategy<Order>>(MinMaxFilterMode.Min);
                    // Register an IMinMaxFilterModeStrategy factory which returns the strategy keyed with the MinMaxFilterMode provided
                    builder.Register<Func<string, MinMaxFilterMode, IMinMaxFilterModeStrategy<Order>>>(context =>
                    {
                        var cc = context.Resolve<IComponentContext>();
                        return (countType, mode) =>
                        {
                            int getItemCountProperty(Order order) => countType switch
                            {
                                nameof(Order.TotalCount) => order.TotalCount,
                                nameof(Order.UniqueCount) => order.UniqueCount,
                                _ => default
                            };
                            return cc.ResolveKeyed<IMinMaxFilterModeStrategy<Order>>(mode, TypedParameter.From<Func<Order, int>>(getItemCountProperty));
                        };
                    });

                    builder.RegisterType<ItemCountFilterMaxStrategy>().As<IMinMaxFilterModeStrategy<ItemVm>>().Keyed<IMinMaxFilterModeStrategy<ItemVm>>(MinMaxFilterMode.Max);
                    builder.RegisterType<ItemCountFilterMinStrategy>().As<IMinMaxFilterModeStrategy<ItemVm>>().Keyed<IMinMaxFilterModeStrategy<ItemVm>>(MinMaxFilterMode.Min);
                    // Register an IMinMaxFilterModeStrategy factory which returns the strategy keyed with the MinMaxFilterMode provided
                    builder.Register<Func<MinMaxFilterMode, IMinMaxFilterModeStrategy<ItemVm>>>(context =>
                    {
                        var cc = context.Resolve<IComponentContext>();
                        return mode => cc.ResolveKeyed<IMinMaxFilterModeStrategy<ItemVm>>(mode);
                    });
                }

                // Strict/Loose filter strategies
                {
                    builder.RegisterType<OrderSearchFilterStrictStrategy>().As<IStrictLooseFilterModeStrategy<Order>>().Keyed<IStrictLooseFilterModeStrategy<Order>>(StrictLooseFilterMode.Strict);
                    builder.RegisterType<OrderSearchFilterLooseStrategy>().As<IStrictLooseFilterModeStrategy<Order>>().Keyed<IStrictLooseFilterModeStrategy<Order>>(StrictLooseFilterMode.Loose);

                    builder.Register<Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy<Order>>>(context =>
                    {
                        var cc = context.Resolve<IComponentContext>();
                        return (searchType, mode) =>
                        {
                            string getOrderProperty(Order order) => searchType switch
                            {
                                nameof(Order.Id) => order.Id.ToString(),
                                nameof(Order.BuyerName) => order.BuyerName,
                                _ => default
                            };
                            return cc.ResolveKeyed<IStrictLooseFilterModeStrategy<Order>>(mode, TypedParameter.From<Func<Order, string>>(getOrderProperty));
                        };
                    });

                    builder.RegisterType<ItemSearchFilterStrictStrategy>().As<IStrictLooseFilterModeStrategy<ItemVm>>().Keyed<IStrictLooseFilterModeStrategy<ItemVm>>(StrictLooseFilterMode.Strict);
                    builder.RegisterType<ItemSearchFilterLooseStrategy>().As<IStrictLooseFilterModeStrategy<ItemVm>>().Keyed<IStrictLooseFilterModeStrategy<ItemVm>>(StrictLooseFilterMode.Loose);

                    builder.Register<Func<string, StrictLooseFilterMode, IStrictLooseFilterModeStrategy<ItemVm>>>(context =>
                      {
                          var cc = context.Resolve<IComponentContext>();
                          return (searchType, mode) =>
                          {
                              string getItemProperty(ItemVm item) => searchType switch
                              {
                                  nameof(ItemVm.Number) => item.Number,
                                  nameof(ItemVm.InventoryId) => item.InventoryId.ToString(),
                                  nameof(ItemVm.Name) => item.Name,
                                  nameof(ItemVm.CategoryId) => item.CategoryId.ToString(),
                                  _ => default
                              };
                              return cc.ResolveKeyed<IStrictLooseFilterModeStrategy<ItemVm>>(mode, TypedParameter.From<Func<ItemVm, string>>(getItemProperty));
                          };
                      });
                }
            }
        }
    }
}
