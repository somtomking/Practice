using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Net4
{
    public class AsyncAndAwait
    {
        // 异步操作
        public static async void AsyncMethod(int input)
        {
            Console.WriteLine("进入异步操作！");
            var result = await AsyncWork(input);
            Console.WriteLine("最终结果{0}", result);
            Console.WriteLine("退出异步操作！");
        }

        // 模拟耗时操作（异步方法）
        public static async Task<int> AsyncWork(int val)
        {
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("耗时操作{0}", i);
                await Task.Delay(100);
                val++;
            }
            return val;
        }


        public static async Task<string> Do()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            await Task.Delay(100);
            return "123";
        }


        static void Main(string[] args)
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
