using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWhereMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var q = arr.Where(x => x % 2 == 1);

            foreach (var x in q)
            {
                Console.WriteLine(x);
            }
        }
    }
}
