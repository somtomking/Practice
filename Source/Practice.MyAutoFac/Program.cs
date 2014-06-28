using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
namespace Practice.MyAutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<NullLoger>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyModules<
            var c = builder.Build();

            var nullObj = c.Resolve<INullObj>();
            var nullLog = c.Resolve<ILoger>();

            Console.WriteLine(Object.ReferenceEquals(nullLog, nullObj));

            Console.Read();

        }
    }
}
