using System;

namespace ArrayOne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            intArray = new int[3] {1, 2, 3 } ;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
            }

            foreach (int i in intArray) { Console.WriteLine("{0}", i); }
        }
    }
}
