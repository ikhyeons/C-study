using System;

namespace IntToBype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 255;
            byte y = (byte)x;

            Console.WriteLine($"{x} => {y}");
        }
    }
}
