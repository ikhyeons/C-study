using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    internal class Program
    {
        static void Main(string[] args) {


        int[] numbers = { 1, 2, 3, 4, 5, };

            var nums = numbers.Where(it => it % 2 == 0 && it > 3);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
