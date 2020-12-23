using Autofac;
using Data.LocalDB;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Data.IoC
{
    public class IoCDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var connectionString = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Users.db3")};Version=3;";
            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(connectionString));
            builder.RegisterType<LoginRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RegisterRepository>().InstancePerLifetimeScope();
        }
    }
}
