using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace Sitecore.DependencyInjection.Website.App_Start.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<IExampleService>().ImplementedBy<ExampleService>().LifestylePerWebRequest());
            
            //Register Glass SitecoreContext
            //container.Register(Component.For<ISitecoreContext>().ImplementedBy<SitecoreContext>().LifestylePerWebRequest());
        }
    }
}