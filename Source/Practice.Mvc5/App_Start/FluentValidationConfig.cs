using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using Practice.Mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Mvc5
{
    public class FluentValidationConfig
    {
        public static void ConfigureContainer()
        {
            // 注册 IoC
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterNewsManagement();
            // 创建 container
            IContainer _container = builder.Build();
            // 在 NewsManagement 模型下设置 container
            _container.SetAsNewsManagementResolver();

            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new AutofacValidatorFactory(_container)));
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }

    }
    public static class AutofacExtensions
    {
        public static void RegisterNewsManagement(this ContainerBuilder builder)
        {

            builder.RegisterType<FormModel.OrderValidator>().As<IValidator<FormModel.Order>>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
        }

        public static void SetAsNewsManagementResolver(this IContainer contaner)
        {
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contaner));
        }
    }

    public class AutofacValidatorFactory : ValidatorFactoryBase
    {
        private readonly IContainer _container;

        public AutofacValidatorFactory(IContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// 尝试创建实例，返回值为 NULL 表示不应用 FluentValidation 来做 MVC 的模型验证
        /// </summary>
        /// <param name="validatorType"></param>
        /// <returns></returns>
        public override IValidator CreateInstance(Type validatorType)
        {
            object instance;
            if (_container.TryResolve(validatorType, out instance))
            {
                return instance as IValidator;
            }



            return null;
        }




    }


}