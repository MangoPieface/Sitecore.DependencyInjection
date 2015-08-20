using Castle.Windsor;
using Sitecore.Mvc.Helpers;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Sitecore.DependencyInjection.ControllerFactories
{
    class WindsorControllerFactory : DefaultControllerFactory
    {
        public IWindsorContainer Container { get; protected set; }
        public IControllerFactory InnerFactory { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="container">The container used to resolve the MVC controllers.</param>
        /// <param name="innerFactory">The innerFactory to pass over resolution of controllers if Windors fails to find controller</param>
        public WindsorControllerFactory(IWindsorContainer container, IControllerFactory innerFactory)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.Container = container;

            if (innerFactory == null)
            {
                throw new ArgumentNullException("innerFactory");
            }
            this.InnerFactory = innerFactory;
        }

        /// <summary>
        /// Retrieves the controller instance for the specified request context and controller type, or hands off to InnerFactory
        /// </summary>
        /// <param name="requestContext">The context of the HTTP request, which includes the HTTP context and route data.</param>
        /// <param name="controllerType">The type of the controller.</param>
        /// <returns>The controller instance.</returns>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }

            // Retrieve the requested controller from Windsor
            if (Container.Kernel.HasComponent(controllerType))
            {
                var controller = Container.Resolve(controllerType) as IController;

                if (controller != null)
                {
                    return controller;
                }
            }

            //If no Controller found in Windsor, then use innerFactor
            return this.InnerFactory.CreateController(requestContext, controllerType.Name.Replace("Controller", string.Empty));
        }

        /// <summary>
        /// Releases the specified controller.
        /// </summary>
        /// <param name="controller">The controller to release.</param>
        public override void ReleaseController(IController controller)
        {
            // If controller implements IDisposable, clean it up responsibly
            var disposableController = controller as IDisposable;
            if (disposableController != null)
            {
                disposableController.Dispose();
            }

            // Inform Castle that the controller is no longer required
            Container.Release(controller);
        }
    }
}
