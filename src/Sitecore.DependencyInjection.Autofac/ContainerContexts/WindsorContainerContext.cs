using Castle.Windsor;

namespace Sitecore.DependencyInjection.ContainerContexts
{
    public static class WindsorContainerContext
    {
        private static readonly IWindsorContainer _instance = new WindsorContainer();

        public static IWindsorContainer Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
