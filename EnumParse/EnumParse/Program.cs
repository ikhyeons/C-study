using System;

namespace EnumParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color = "Blue";

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            Console.WriteLine((ConsoleColor)Enum.Parse(typeof(ConsoleColor), color));
            Console.WriteLine("Red");
            Console.WriteLine();
        }
    }
}
