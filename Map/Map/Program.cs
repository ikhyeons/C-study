using System;
using System.Collections.Generic;
using System.Linq;

namespace Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};

            var nums = numbers.Select(it => it * it);

            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
