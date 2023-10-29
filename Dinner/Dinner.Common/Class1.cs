using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dinner.Common
{
    public class Cooking
    {
        public Rice MakeRice()
        {
            Console.WriteLine("밥 생성 중...");
            Thread.Sleep(1001);
            return new Rice();
        }
        public async Task<Rice> MakeRiceAsync()
        {
            await Console.Out.WriteLineAsync("밥 생성 중...");
            await Task.Delay(1001);
            return new Rice();
        }

        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성 중...");
            Thread.Sleep(1001);
            return new Soup();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성 중...");
            Thread.Sleep(1001);
            return new Soup();
        }
        public Egg MakeSoupEgg()
        {
            Console.WriteLine("달걀 생성 중...");
            Thread.Sleep(1001);
            return new Egg();
        }

        public async Task<Egg> MakeSoupEggAsync()
        {
            Console.WriteLine("달걀 생성 중...");
            Thread.Sleep(1001);
            return new Egg();
        }

    }



    public class Rice { }
    public class Soup { }
    public class Egg { }
}