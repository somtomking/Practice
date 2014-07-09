using Practice.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Practice.WebAPI.Controllers
{
    public class TestController : ApiController
    {
        IList<TestModel> _data = TestModel.Data();
        public TestController()
        {

        }
        // GET: api/Test
        public IEnumerable<TestModel> Get()
        {
           
            return _data;
        }

        // GET: api/Test/5
        public TestModel Get(int id)
        {
            return _data.FirstOrDefault(s => s.Id == id);
        }
       
        public TestModel GetByCategory(string category)
        {
            return _data.FirstOrDefault(s => s.Category == category);
        }
        // POST: api/Test
        public void Post([FromBody]TestModel model)
        {
            _data.Add(model);
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]TestModel model)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
            var data = _data.FirstOrDefault(s => s.Id == id);
            if (data != null)
            {
                _data.Remove(data);
            }

        }
    }
}
