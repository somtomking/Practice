using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using Practice.Mvc5.Services;
namespace Practice.Mvc5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IContainer Container { get; private set; }
        protected void Application_Start()
        {
           


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            FluentValidationConfig.ConfigureContainer();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<AutoFacTestService>().As<IAutoFacTestService>().InstancePerLifetimeScope();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            var container = builder.Build();
            MvcApplication.Container = container;
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }


    }
}
