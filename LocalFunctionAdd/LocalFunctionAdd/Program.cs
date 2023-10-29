using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Add(int a, int b) => a + b;
            decimal Subtract(decimal x, decimal y ) => x - y;

            Console.WriteLine($"3 + 5 = {Add(3, 5)}");
            Console.WriteLine($"34.56 - 12.34 = {Subtract(34.56M, 12.34M)}");
        }
    }w
}
