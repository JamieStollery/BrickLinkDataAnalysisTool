using Autofac;
using Data.Common;
using Data.LocalDB;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Test.Integration
{
    public class TestingIoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var connectionString = $"Data Source={Path.Combine(folderPath, "Orders_IntegrationTesting.db3")};Version=3;";
            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(connectionString)).SingleInstance();
            builder.RegisterType<DapperWrapper>().As<IDapperWrapper>().InstancePerLifetimeScope();
            builder.RegisterType<DatabaseUpdater>().As<IDatabaseUpdater>().InstancePerLifetimeScope();
            builder.RegisterType<OrdersDatabaseInitializer>().As<IDatabaseInitializer>().InstancePerLifetimeScope();
        }
    }
}
