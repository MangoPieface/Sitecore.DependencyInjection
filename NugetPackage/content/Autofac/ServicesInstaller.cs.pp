using System;
using Autofac;
//using Example.Library.Services;

namespace $rootnamespace$.Website.Installers
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