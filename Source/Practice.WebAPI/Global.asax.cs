using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.WebApi;
using Practice.WebAPI.Authorize;
using Practice.WebAPI.Autofac;
using Practice.WebAPI.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Practice.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            builder.RegisterModule(new WebApiAutofacModule());
            builder.RegisterModule(new ApplicationServiceAutofacModule());
            IContainer container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
         
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configuration.Filters.Add(new CustomAuthorizeAttribute());
            // GlobalConfiguration.Configuration.MessageHandlers.Add(new CustomMessageHandler());
            
        }
    }
}
