using Practice.Mvc5.Models;
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
            MvcModel.Contact c = new MvcModel.Contact() { Email = "Somtomking@163.com", Name = "liust", PhoneNo = "18173956855" };

           
            return View(c);
        }

    }
}