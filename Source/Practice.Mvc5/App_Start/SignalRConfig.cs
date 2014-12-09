using Practice.Mvc5.Infrastructure.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Practice.Mvc5.App_Start
{
    public class SignalRConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapConnection<MyConnection>("echo", "echo/{*operation}");
        }
    }
}