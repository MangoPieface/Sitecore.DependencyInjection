﻿using Sitecore.DependencyInjection.ContainerContexts;
using Sitecore.DependencyInjection.DependencyResolvers;
using System.Web.Routing;

namespace Sitecore.DependencyInjection.Website.App_Start
{
    public class Application : Sitecore.Web.Application
    {
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
        }
    }
}