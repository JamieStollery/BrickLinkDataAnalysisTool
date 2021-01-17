using Autofac;
using Autofac.Core;
using Data.BrickLinkAPI;
using Data.Common;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using Data.LocalDB;
using OAuth;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Net;

namespace Data.IoC
{
    public class IoCDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<User>().SingleInstance();

            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var usersConnectionString = $"Data Source={Path.Combine(folderPath, "Users.db3")};Version=3;";
            var ordersConnectionString = $"Data Source={Path.Combine(folderPath, "BrickLink.db3")};Version=3;";

            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(usersConnectionString)).Keyed<IDbConnection>(Database.Users).SingleInstance();
            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(ordersConnectionString)).Keyed<IDbConnection>(Database.Orders).SingleInstance();

            builder.RegisterType<UserRepository>().As<ILoginRepository>().As<IRegisterRepository>().WithParameter(ResolvedParameter.ForKeyed<IDbConnection>(Database.Users)).InstancePerLifetimeScope();

            builder.RegisterType<BrickLinkRequestFactory>().SingleInstance();

            builder.RegisterType<ItemImageRepository>().As<IItemImageRepository>().InstancePerLifetimeScope();

            builder.RegisterType<BrickLinkAPI.OrderRepository>().As<IOrderRepository>().Keyed<IOrderRepository>(DataMode.API).InstancePerLifetimeScope();
            builder.RegisterType<LocalDB.OrderRepository>().As<IOrderRepository>().Keyed<IOrderRepository>(DataMode.Database).InstancePerLifetimeScope();
            builder.Register<Func<DataMode, IOrderRepository>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return mode => mode == DataMode.Database ? cc.ResolveKeyed<IOrderRepository>(mode, ResolvedParameter.ForKeyed<IDbConnection>(Database.Orders)) : cc.ResolveKeyed<IOrderRepository>(mode);
            });
        }

        private enum Database
        {
            Users,
            Orders
        }
    }
}
