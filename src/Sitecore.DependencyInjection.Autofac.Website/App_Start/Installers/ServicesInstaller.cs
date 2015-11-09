using System;
using Autofac;
using Example.Library.Services;
using Glass.Mapper.Sc;

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

            builder.RegisterType<ExampleService>().As<IExampleService>().InstancePerDependency();

            //Sitecore Glass context this should *just work* with Glass 4.X
            builder.RegisterType<SitecoreContext>().As<ISitecoreContext>().InstancePerDependency();

        }
    }
}