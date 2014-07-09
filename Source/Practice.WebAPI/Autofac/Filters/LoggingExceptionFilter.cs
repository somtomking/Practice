using System;
using System.Web.Http.Filters;
using Autofac.Integration.WebApi;

using Practice.WebAPI.Code.Loger;

namespace Practice.WebAPI.Autofac
{
    public class LoggingExceptionFilter : IAutofacExceptionFilter
    {
        private readonly ILogFacadeService _logger;

        public LoggingExceptionFilter(ILogFacadeService logger)
        {
            _logger = logger;
        }

        public void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Exception exception = actionExecutedContext.Exception;
            _logger.AddErrorLog(exception.Message, exception.ToString());
        }
    }
}