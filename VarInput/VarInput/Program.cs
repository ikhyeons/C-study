using System;
using System.Runtime.InteropServices;

namespace VarInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var c = Convert.ToChar(Console.Read());
            Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
        }
    }
}