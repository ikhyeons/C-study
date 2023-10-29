using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3};
            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");
        }
    }
}
