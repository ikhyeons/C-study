using System;

namespace ReadLineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long l = long.MaxValue;
            Console.WriteLine($"l의 값 : {l}");
            int i = (int)l;
            Console.WriteLine($"i의 값 : {i}");
        }
    }
}