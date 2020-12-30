﻿using Autofac;
using Data.Common.Model;
using Data.Common.Model.Validation;
using Data.LocalDB;
using FluentValidation;
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
            builder.RegisterType<User>().SingleInstance();

            builder.RegisterType<LoginUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Login).InstancePerLifetimeScope();
            builder.RegisterType<RegisterUserValidator>().As<IValidator<User>>().Keyed<IValidator<User>>(UserValidationType.Register).InstancePerLifetimeScope();
            builder.Register<Func<UserValidationType, IValidator<User>>>(context =>
            {
                var cc = context.Resolve<IComponentContext>();
                return validationType => cc.ResolveKeyed<IValidator<User>>(validationType);
            });

            var connectionString = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Users.db3")};Version=3;";
            builder.RegisterInstance<IDbConnection>(new SQLiteConnection(connectionString));
            builder.RegisterType<LoginRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RegisterRepository>().InstancePerLifetimeScope();
        }
    }
}
