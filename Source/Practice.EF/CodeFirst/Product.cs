using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF.CodeFirst
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class SimpleProduct : Product
    {
        public string Desc { get; set; }
    }

    public class BookProduct : Product
    {
        public string Mark { get; set; }
    }


}
