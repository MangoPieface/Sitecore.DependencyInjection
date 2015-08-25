using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace Sitecore.DependencyInjection.Website.App_Start.Installers
{
    public class MvcControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Classes.FromAssemblyNamed("ExampleLibrary.Controllers").BasedOn<IController>().LifestyleTransient());
        }
    }
}