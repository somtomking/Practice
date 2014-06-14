using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLife.Log;
using NewLife.CommonEntity;
namespace Practice.NewLifes.ConClient
{
    class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole();
            while (true)
            {
                try
                {
                    TestFind();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }
                Console.WriteLine("Ok!");
                var ck = Console.ReadKey(true);
                if (ck.KeyChar!='c')
                {
                    break;
                }
            }

        }
        static void TestFind()
        {
            var entity = Area.FindByID(1);
            if (entity != null)
            {
                Console.WriteLine("{0} {1}", entity.Code, entity.Name);
            }
        }
    }
}
