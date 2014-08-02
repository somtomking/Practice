using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Practice.SelfHostWebAPI.Controller
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "123";
        }
    }
}
