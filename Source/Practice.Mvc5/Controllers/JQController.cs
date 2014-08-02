using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Mvc5.Controllers
{
    public class JQController : Controller
    {
        // GET: JQ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Lightbox_me()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lightbox_me(string msg)
        {
            
            
            return View();
        }

        public ActionResult Validate()
        {
            return View();
        }
        public ActionResult Validate2()
        {
            return View();
        }
        public ActionResult Validate3()
        {
            return View();
        }


        public ActionResult Template()
        {
            return View();
        }
    }
}