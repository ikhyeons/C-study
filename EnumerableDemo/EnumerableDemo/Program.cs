using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 5);
            foreach(var n  in numbers)
            {
                Console.WriteLine("{0}   ", n);
            }
            Console.WriteLine() ;
             
            var sameNumbers = Enumerable.Repeat(-1, 5);
            foreach (var n in sameNumbers) Console.WriteLine("{0}   ", n);
            Console.WriteLine();
        }
    }
}
