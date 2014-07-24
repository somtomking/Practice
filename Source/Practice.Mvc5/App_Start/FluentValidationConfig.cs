using FluentValidation;
using FluentValidation.Mvc;
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
            var factory = new  DependencyResolverValidatorFactory();
            ModelValidatorProviders.Providers
                .Add(new FluentValidationModelValidatorProvider(factory));
            DataAnnotationsModelValidatorProvider
                .AddImplicitRequiredAttributeForValueTypes = false;
            
            //ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;
        }
    }

    public class DependencyResolverValidatorFactory : ValidatorFactoryBase
    {
        public override IValidator CreateInstance(Type validatorType)
        {
            return DependencyResolver.Current.GetService(validatorType) as IValidator;
        }
    }


     
}