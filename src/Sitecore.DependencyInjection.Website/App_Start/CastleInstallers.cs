using Sitecore.DependencyInjection.ContainerContexts;
using Sitecore.DependencyInjection.Website.App_Start.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Sitecore.DependencyInjection.Website.App_Start.CastleInstallers), "Start")]

namespace Sitecore.DependencyInjection.Website.App_Start
{
    public class CastleInstallers
    {
        public static void Start()
        {
            //Register Controllers with WindsorContainer
            WindsorContainerContext.Instance.Install(new MvcControllersInstaller());
            //Register Services with WindsorContainer
            WindsorContainerContext.Instance.Install(new ServicesInstaller());
        }
    }
}