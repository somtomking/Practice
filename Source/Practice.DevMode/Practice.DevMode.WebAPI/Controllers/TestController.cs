using Practice.DevMode.WebAPI.Infrastructure.Authorize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Practice.DevMode.WebAPI.Controllers
{
    public class TestController : ApiController
    {
        [HTTPBasicAuthorizeAttribute]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/test/5
        public string Get(int id)
        {
            if (HttpContext.Current.Session["v"] == null)
            {
                return "NULL";
            }
            else
            {
                return HttpContext.Current.Session["v"].ToString();
            }

        }

        // POST api/test
        public void Post([FromBody]string value)
        {
            HttpContext.Current.Session["v"] = value;
        }

        // PUT api/test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/test/5
        public void Delete(int id)
        {
        }
    }
}
