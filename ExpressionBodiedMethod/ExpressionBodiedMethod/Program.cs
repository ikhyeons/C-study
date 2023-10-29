using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log("함수 축약");
            Console.WriteLine(IsSame("A", "B"));
        }
        static void Log(string message) => Console.WriteLine(message);
        static bool IsSame(string a, string b) => a == b;
    }
}
