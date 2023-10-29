using System;
using static System.Console;
using static System.Math;

namespace UsingStaticClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Math.Pow(2, 10));

            WriteLine(Pow(2, 10));
            WriteLine(Max(3, 5));
            
        }
    }
}
