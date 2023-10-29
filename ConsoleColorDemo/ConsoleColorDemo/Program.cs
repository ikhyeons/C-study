using System;

namespace ConsoleColorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("blue");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();
        }
    }
}
