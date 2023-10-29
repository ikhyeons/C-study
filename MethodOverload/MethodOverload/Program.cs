using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hi();
            Hi("1234");
        }

        static void Hi()
        {
            Console.WriteLine("안녕하세요");
        }

        static void Hi(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
