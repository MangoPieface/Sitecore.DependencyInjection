using Castle.Windsor;

namespace Sitecore.DependencyInjection.ContainerContexts
{
    public static class WindsorContainerContext
    {
        private static readonly object Padlock = new object();
        private static IWindsorContainer _instance;

        public static IWindsorContainer Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new WindsorContainer());
                }
            }
            set
            {
                lock (Padlock)
                {
                    _instance = value;
                }
            }
        }
    }
}
