using Practice.EF.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF
{
    class Start
    {
        static void Main(string[] args)
        {

            using (MyDbContext dbContext = new MyDbContext())
            {
           
                dbContext.Database.Log = s => Console.WriteLine(s);
                dbContext.Order.Include(s => s.OrderItems).ToList();
                dbContext.Order.ToList();
               
            }



        }
    }
}
