using Autofac;
using Practice.WebAPI.Code.Loger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.WebAPI.Autofac
{
    public class ApplicationServiceAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<LogFacadeService>().As<ILogFacadeService>();
        }
    }
}