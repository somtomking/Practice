using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice.Mvc5.Startup))]
namespace Practice.Mvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
