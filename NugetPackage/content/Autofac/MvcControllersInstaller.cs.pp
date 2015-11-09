using System;
using Autofac;
using Autofac.Integration.Mvc;
using Example.Library.Controllers.InjectionExample;

namespace $rootnamespace$.Installers
{
        /// <summary>
        /// Handles the registering for the MVC controllers. 
        /// it uses the Autofac.MVC5 nuget package
        /// </summary>
        public class MvcControllersInstaller
        {

            /// <summary>
            /// Registers the controllers
            /// </summary>
            /// <param name="builder">The Autofac builder.</param>
            /// <exception cref="System.ArgumentNullException"></exception>
            public void Register(ContainerBuilder builder)
            {
                if (builder == null)
                {
                    throw new ArgumentNullException(nameof(builder));
                }

                builder.RegisterControllers(typeof(InjectionExampleController).Assembly);
            }
        }
}