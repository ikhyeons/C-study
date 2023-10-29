using System;

namespace ParamsDemo
{
    internal class Program
    {
        static int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumAll(3, 5));
            Console.WriteLine(SumAll(3, 5, 7));
            Console.WriteLine(SumAll(3, 5, 7, 9));
        }
    }
}
