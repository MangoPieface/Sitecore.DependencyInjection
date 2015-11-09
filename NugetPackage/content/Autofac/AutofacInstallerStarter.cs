using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Sitecore.DependencyInjection.Autofac.Website;
using Sitecore.DependencyInjection.Autofac.Website.Installers;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(AutofacInstallerStarter), "Start")]

namespace Sitecore.DependencyInjection.Autofac.Website
{
    public class AutofacInstallerStarter
    {
        public static void Start()
        {
            var builder = new ContainerBuilder();

            RegisterControllers(builder);
            RegisterServices(builder);
            RegisterGlass(builder);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }

        private static void RegisterControllers(ContainerBuilder builder)
        {
            var controllerInstall = new MvcControllersInstaller();
            controllerInstall.Register(builder);
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            var servicesInstaller = new ServicesInstaller();
            servicesInstaller.Register(builder);
        }


        private static void RegisterGlass(ContainerBuilder builder)
        {
            var servicesInstaller = new GlassInstaller();
            servicesInstaller.Register(builder);
        }
    }
}