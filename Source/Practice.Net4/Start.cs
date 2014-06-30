using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Net4
{
    public class Start
    {

        static void  Main(string[] args)
        {
              Test();
             Console.WriteLine("end!");
            Console.ReadKey();
        }

        private static async Task Test()
        {
            var strTask = AsyncAndAwait.Do();
            var result = await strTask;
            Console.WriteLine(result);
           
        }

    }
}
