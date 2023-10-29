using System;

namespace ParameterRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine($"[1] {num}");

            Do(ref num);
            Console.WriteLine($"[3] {num}");
        }

        static void Do(ref int num)
        {
            num = 20;
            Console.WriteLine($"[2] {num}");
        }
    }
}
