using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.WebAPI.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }


        public static IList<TestModel> Data()
        {
            IList<TestModel> data = new List<TestModel>();
            data.Add(new TestModel { Id = 1, Name = "liust", Category = "boy" });
            data.Add(new TestModel { Id = 2, Name = "avlin", Category = "girl" });
            data.Add(new TestModel { Id = 3, Name = "li", Category = "bou" });
            data.Add(new TestModel { Id = 4, Name = "liust4", Category = "boy" });
            data.Add(new TestModel { Id = 5, Name = "liust5", Category = "boy" });
            data.Add(new TestModel { Id = 6, Name = "liust6", Category = "girl" });
            data.Add(new TestModel { Id = 7, Name = "liust7", Category = "boy" });
            data.Add(new TestModel { Id = 8, Name = "liust8", Category = "boy" });
            data.Add(new TestModel { Id = 9, Name = "liust9", Category = "boy" });
            data.Add(new TestModel { Id = 10, Name = "liust10", Category = "girl" });


            return data;
        }
    }
}