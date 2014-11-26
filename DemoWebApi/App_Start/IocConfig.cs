using Autofac;
using Autofac.Integration.Mvc;
using DemoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApi.App_Start
{
    public class IocConfig
    {
        public static IContainer RegisterDependencies()
        {
            try
            {
                var containerBuilder = new ContainerBuilder();

                /*Register all the controllers within the current assembly.*/
              //  containerBuilder.RegisterControllers(typeof(HomeController).Assembly);

                /*Register Libs Files Here*/
               

                /*Register ObjectContexts*/
                containerBuilder.RegisterType<ApplicationDbContext>()
                    .As<DbContext>().InstancePerDependency();



                /*Register other dependencies.*/
                


                var container = containerBuilder.Build();
                var resolver = new AutofacDependencyResolver(container);
                DependencyResolver.SetResolver(resolver);
                return container;

            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
    }
}