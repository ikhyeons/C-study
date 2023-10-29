using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumber(1234);
            GetNumber(1234L);
        }
        static void GetNumber(int number)
        {
            Console.WriteLine($"int32 : {number}");
        }

        static void GetNumber(long number)
        {
            Console.WriteLine($"int64 : {number}");
        }
    }
}
