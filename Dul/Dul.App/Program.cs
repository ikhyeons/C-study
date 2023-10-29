using System;

namespace Dul.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dul.Creator.GetName());
            Console.WriteLine(Dul.Math.Abs(-1234));
            Console.WriteLine("안녕하세요.".CutStringUnicode(6));
        }
    }
}
