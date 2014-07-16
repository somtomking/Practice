using Practice.Mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Mvc5.Controllers
{
    public class TestController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JQ()
        {
            return View();
        }

        public ActionResult Sel()
        {
            return View();
        }

        public ActionResult Json()
        {
            Dictionary<string, ProvinceModel> dic = new Dictionary<string, ProvinceModel>();
            for (int loop = 0; loop < 3; loop++)
            {
                ProvinceModel pm = new ProvinceModel() { Id = "A" + loop, Name = loop.ToString() };

                for (int loop3 = 0; loop3 < 2; loop3++)
                {
                    pm.Cities.Add(new CityModel { Id = "B" + loop3, Name = loop3.ToString() });
                }


                dic.Add("A" + loop, pm);

            }
            ViewBag.Json1 = Newtonsoft.Json.JsonConvert.SerializeObject(dic);

            Dictionary<int, List<int>> dict2 = new Dictionary<int, List<int>>();
            for (int loop = 0; loop < 5; loop++)
            {
                dict2.Add(loop, new List<int>());
                for (int loop2 = 0; loop2 < 3; loop2++)
                {
                    dict2[loop].Add(loop2);
                }
            }

            ViewBag.Json2 = Newtonsoft.Json.JsonConvert.SerializeObject(dict2);

            return View();
        }

        
    }


}

