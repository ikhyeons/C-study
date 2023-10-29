using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGetLengthDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            Console.WriteLine("차수 출력 : {0}", array.Rank);
            Console.WriteLine("길이 출력 : {0}", array.Length);

            for (int i = 0; i < array.GetLength(0); i++) { 
                for(int j = 0; j<array.GetLength(1); j++)
                {
                    for(int k = 0; k<array.GetLength(2); k++) {
                        Console.Write($"{array[i,j,k],2}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
