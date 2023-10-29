using System;
using System.Diagnostics;
using Dinner.Common;

namespace Dinner.Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Rice rice = (new Cooking()).MakeRice();
            Console.WriteLine("밥 준비 완료");

            Soup soup = (new Cooking()).MakeSoup();
            Console.WriteLine("국 준비 완료");

            Egg egg = (new Cooking()).MakeSoupEgg();
            Console.WriteLine("달걀 준비 완료");

            stopwatch.Stop();

            Console.WriteLine($"\n시간 : {stopwatch.ElapsedMilliseconds}밀리초");
            Console.WriteLine("동기 방식으로 식사 준비 완료");
        }
    }
}