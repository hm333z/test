using System;
using System.Threading;
using System.Threading.Tasks;

namespace threadtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().test();
            Console.WriteLine("主线程的");
            Thread.Sleep(500);
            Console.WriteLine("你好！");
            Console.Read();
        }
        async void test()
        {
            Console.WriteLine("异步开始外");
            Task<int> nmsl=Test(5);
            Console.WriteLine("你好呀");
            Thread.Sleep(100);
            Console.WriteLine("nmsl");
            await nmsl;
            Console.WriteLine("异步结束外");
        }
        static Task<int> Test(int n)
        {
            return Task<int>.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("异步任务" + i);
                    Thread.Sleep(100);
                }
                Console.WriteLine("异步结束内");
                return n;

            });
        }
    }
}
