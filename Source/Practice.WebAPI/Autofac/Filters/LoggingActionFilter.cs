using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Autofac.Integration.WebApi;


using Practice.WebAPI.Code.Loger;

namespace Practice.WebAPI.Autofac
{
    public class LoggingActionFilter : IAutofacActionFilter
    {
        private readonly ILogFacadeService _logger;

        public LoggingActionFilter(ILogFacadeService logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(HttpActionContext actionContext)
        {
            //string requestUri = actionContext.Request.RequestUri.ToString();
            //string method = actionContext.Request.Method.Method;
            //string actionName = actionContext.ActionDescriptor.ActionName;
            //IDictionary<string, object> actionArguments = actionContext.ActionArguments;
        }

        public void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string requestUri = actionExecutedContext.Request.RequestUri.ToString();
            //string method = actionExecutedContext.Request.Method.Method;
            string actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            IDictionary<string, object> actionArguments = actionExecutedContext.ActionContext.ActionArguments;
            var statusCode = (int)actionExecutedContext.Response.StatusCode;
            _logger.AddServiceLog(actionName, statusCode, requestUri, actionArguments.ToString());
        }
    }
}