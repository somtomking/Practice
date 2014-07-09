using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
 
using Module = Autofac.Module;
using Practice.WebAPI.Code.Loger;

namespace Practice.WebAPI.Autofac
{
    public class WebApiAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.OverrideWebApiActionFilterFor<ApiController>();
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
            builder.Register(c => new LoggingExceptionFilter(c.Resolve<ILogFacadeService>()))
                .AsWebApiExceptionFilterFor<ApiController>()
                .InstancePerRequest();
            builder.Register(c => new LoggingActionFilter(c.Resolve<ILogFacadeService>()))
                .AsWebApiActionFilterFor<ApiController>()
                .InstancePerRequest();
        }
    }
}