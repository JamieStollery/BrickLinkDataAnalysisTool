using Autofac;
using Autofac.Core;
using Data.BrickLinkAPI;
using Data.Common;
using Data.Common.Model;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Data.LocalDB;
using FluentValidation;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Data.IoC
{
    public partial class IoCDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserOption>().As<IOption<User>>().SingleInstance();
            builder.RegisterType<DataModeOption>().As<IOption<DataMode>>().SingleInstance();

            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var usersConnectionString = $"Data Source={Path.Combine(folderPath, "Users.db3")};Version=3;";
            var ordersConnectionString = $"Data Source={Path.Combine(folderPath, "Orders.db3")};Version=3;";

            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(usersConnectionString)).Keyed<IDbConnection>(Database.Users).SingleInstance();
            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(ordersConnectionString)).Keyed<IDbConnection>(Database.Orders).SingleInstance();

            builder.RegisterType<DapperWrapper>().As<IDapperWrapper>().WithParameter(ResolvedParameter.ForKeyed<IDbConnection>(Database.Orders)).Keyed<IDapperWrapper>(Database.Orders).InstancePerLifetimeScope();
            builder.RegisterType<DapperWrapper>().As<IDapperWrapper>().WithParameter(ResolvedParameter.ForKeyed<IDbConnection>(Database.Users)).Keyed<IDapperWrapper>(Database.Users).InstancePerLifetimeScope();

            builder.RegisterType<LoginRepository>().As<ILoginRepository>()
                .WithParameters(new[] {
                    ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Users),
                    ResolvedParameter.ForKeyed<IValidator<User>>(Validator.Login)
                }).InstancePerLifetimeScope();

            builder.RegisterType<RegisterRepository>().As<IRegisterRepository>()
                .WithParameters(new[] {
                    ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Users),
                    ResolvedParameter.ForKeyed<IValidator<User>>(Validator.Register)
                    }).InstancePerLifetimeScope();

            builder.RegisterType<RegisterUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(Validator.Register)
                .WithParameter(ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Users)).InstancePerLifetimeScope();

            builder.RegisterType<LoginUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(Validator.Login)
                .WithParameter(ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Users)).InstancePerLifetimeScope();

            builder.RegisterType<BrickLinkRequestFactory>().As<IBrickLinkRequestFactory>();
            builder.Register<Func<User, IBrickLinkRequestFactory>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return user => cc.Resolve<IBrickLinkRequestFactory>(TypedParameter.From(user));
            });

            builder.RegisterType<ItemImageRepository>().As<IItemImageRepository>().InstancePerLifetimeScope();

            builder.RegisterType<BrickLinkAPI.OrderRepository>().As<IOrderRepository>().Keyed<IOrderRepository>(DataMode.API).InstancePerLifetimeScope();
            builder.RegisterType<LocalDB.OrderRepository>().As<IOrderRepository>().Keyed<IOrderRepository>(DataMode.Database).InstancePerLifetimeScope();
            builder.Register<Func<IOrderRepository>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return () =>
                {
                    var mode = cc.Resolve<IOption<DataMode>>().Value;
                    return mode switch
                    {
                        DataMode.Database => cc.ResolveKeyed<IOrderRepository>(mode, ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Orders)),
                        DataMode.API => cc.ResolveKeyed<IOrderRepository>(mode),
                        _ => null
                    };
                };
            });

            builder.RegisterType<DatabaseUpdater>().As<IDatabaseUpdater>()
                .WithParameters(new[]{
                    ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Orders),
                    ResolvedParameter.ForKeyed<IOrderRepository>(DataMode.API)
                }).InstancePerLifetimeScope();

            builder.RegisterType<OrdersDatabaseInitializer>().As<IDatabaseInitializer>().Keyed<IDatabaseInitializer>(Database.Orders)
                .WithParameter(ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Orders)).InstancePerLifetimeScope();

            builder.RegisterType<UsersDatabaseInitializer>().As<IDatabaseInitializer>().Keyed<IDatabaseInitializer>(Database.Users)
                .WithParameter(ResolvedParameter.ForKeyed<IDapperWrapper>(Database.Users)).InstancePerLifetimeScope();
        }

        private enum Validator
        {
            Register,
            Login
        }
    }
}
