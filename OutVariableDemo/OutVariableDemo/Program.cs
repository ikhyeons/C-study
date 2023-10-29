using System;

namespace OutVariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.TryParse("2019.12.25", out var xmas)) {
                Console.WriteLine(xmas);
            }
        }
    }
}
