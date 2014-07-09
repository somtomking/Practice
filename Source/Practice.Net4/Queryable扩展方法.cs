using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Net4
{
    public class QueryableTest
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            var queryData = DataItem.Data();
            var query = GetArray(5);
            Console.WriteLine("begin-----------------Aggregate---------------begin:");
            var result = query.Aggregate((total, next) =>
                            {
                                var r = total + next;

                                return r;
                            });

            var result2 = query.Aggregate<int, string, string>("A&", (t, n) =>
            {
                return t + n + "&";
            }, (s) => { return s + "!"; });
            Console.WriteLine(result);

            Console.WriteLine(result2);

            Console.WriteLine("end-----------------Aggregate---------------end:");

            Console.WriteLine("begin-----------------Average---------------begin:");

            var result3 = queryData.Average(s => s.Price);
            Console.WriteLine(result3);
            Console.WriteLine("end-----------------Average---------------end:");

            var result4 = queryData.DefaultIfEmpty();
            queryData.ToLookup()
            Console.Read();
        }
        static IEnumerable<int> GetArray(int max)
        {
            List<int> result = new List<int>(max);
            for (int i = 0; i < max; i++)
            {
                result.Add(i + 1);
            }
            return result;

        }
        public class DataItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public static IList<DataItem> Data()
            {
                IList<DataItem> data = new List<DataItem>();
                data.Add(new DataItem { Id = 1, Name = "liust", Category = "boy", Price = 1 });
                data.Add(new DataItem { Id = 2, Name = "avlin", Category = "girl", Price = 2 });
                data.Add(new DataItem { Id = 3, Name = "li", Category = "bou", Price = 3 });
                data.Add(new DataItem { Id = 4, Name = "liust4", Category = "boy", Price = 4 });
                data.Add(new DataItem { Id = 5, Name = "liust5", Category = "boy", Price = 5 });
                data.Add(new DataItem { Id = 6, Name = "liust6", Category = "girl", Price = 6 });
                data.Add(new DataItem { Id = 7, Name = "liust7", Category = "boy", Price = 7 });
                data.Add(new DataItem { Id = 8, Name = "liust8", Category = "boy", Price = 8 });
                data.Add(new DataItem { Id = 9, Name = "liust9", Category = "boy", Price = 9 });
                data.Add(new DataItem { Id = 10, Name = "liust10", Category = "girl", Price = 10 });

                return data;
            }
        }
    }
}
