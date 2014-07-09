using Practice.WebAPI.Authorize;
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
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configuration.Filters.Add(new CustomAuthorizeAttribute());
            // GlobalConfiguration.Configuration.MessageHandlers.Add(new CustomMessageHandler());

        }
    }
}
