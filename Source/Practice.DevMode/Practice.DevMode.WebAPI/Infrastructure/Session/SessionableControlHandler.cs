using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.WebHost;
using System.Web.Routing;
using System.Web.SessionState;

namespace Practice.DevMode.WebAPI.Infrastructure.Session
{
    public class SessionableControlHandler : HttpControllerHandler, IRequiresSessionState
    {
        public SessionableControlHandler(RouteData routeData)
            : base(routeData)
        {
        }
    }
}