using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Routing;

namespace Zouave.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

           GlobalConfiguration.Configure(WebApiConfig.Register);

           //IOC
           ContainerBuilder builder = new ContainerBuilder();
           var container = builder.Build();
           var resolver = new AutofacWebApiDependencyResolver(container);


           GlobalConfiguration.Configuration.DependencyResolver = resolver;//ApiController　WebApi注
        }
    }
}
