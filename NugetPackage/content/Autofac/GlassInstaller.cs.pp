using System;
using Autofac;
//using Glass.Mapper.Sc;

namespace $rootnamespace$.Installers
{
    public class GlassInstaller
    {
        public void Register(ContainerBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            //Sitecore Glass context this should *just work* with Glass 4.X
            //builder.RegisterType<SitecoreContext>().As<ISitecoreContext>().InstancePerDependency();

        }
    }
}