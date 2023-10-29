using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(first : 10, second : 20);
            Sum(second : 10, first : 20);
        }
        
        static void Sum(int first, int second)
        {
            Console.WriteLine(first + second);
        }
    }
}
