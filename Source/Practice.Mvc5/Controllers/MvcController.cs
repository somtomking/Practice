using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Mvc5.Controllers
{
    public class MvcController : Controller
    {
        // GET: Mvc
        public ActionResult Index()
        {

           
            return View();
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            base.OnActionExecuting(filterContext);
        }
    }
}