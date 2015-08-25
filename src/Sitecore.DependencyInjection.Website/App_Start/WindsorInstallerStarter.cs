using Sitecore.ContentSearch.SolrProvider.CastleWindsorIntegration;
using Sitecore.DependencyInjection.ContainerContexts;
using Sitecore.DependencyInjection.Website.App_Start;
using Sitecore.DependencyInjection.Website.App_Start.Installers;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(WindsorInstallerStarter), "Start")]

namespace Sitecore.DependencyInjection.Website.App_Start
{
    public class WindsorInstallerStarter
    {
        public static void Start()
        {
            //Register Controllers with WindsorContainer
            WindsorContainerContext.Instance.Install(new MvcControllersInstaller());
            //Register Services with WindsorContainer
            WindsorContainerContext.Instance.Install(new ServicesInstaller());
            //Initialise Solr with WindsorContainer
            //new WindsorSolrStartUp(WindsorContainerContext.Instance).Initialize();
        }
    }
}