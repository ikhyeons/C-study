using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = { { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } } };

            for (int i = 0; i < 2; i++) { 
            for (int j = 0; j < 3; j++) { 
                for(int k = 0; k < 4; k++)
                    {
                        Console.Write($"{array[i,j,k]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
