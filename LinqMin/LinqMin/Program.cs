using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double> { 3.3, 2.2, 1, 1 };

            var min = numbers.Min();

            Console.WriteLine($"{nameof(numbers)} 리스트의 최솟값 : {min:.00}");
        }
    }
}
