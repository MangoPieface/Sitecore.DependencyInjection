﻿using System;
using Autofac;
//using Example.Library.Services;

namespace Sitecore.DependencyInjection.Autofac.Website.Installers
{
    public class ServicesInstaller
    {
        public void Register(ContainerBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            //builder.RegisterType<ExampleService>().As<IExampleService>().InstancePerDependency();

        }
    }
}