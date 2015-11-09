using Sitecore.DependencyInjection.ContainerContexts;
using Sitecore.DependencyInjection.ControllerFactories;
using Sitecore.Pipelines;
using System.Web.Mvc;

namespace Sitecore.DependencyInjection.FactoryInitializers
{
    public class InitializeWindsorControllerFactory
    {
        public virtual void Process(PipelineArgs args)
        {
            this.SetControllerFactory(args);
        }

        protected virtual void SetControllerFactory(PipelineArgs args)
        {
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(WindsorContainerContext.Instance, ControllerBuilder.Current.GetControllerFactory()));
        }
    }
}
