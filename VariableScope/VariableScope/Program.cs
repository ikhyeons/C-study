using System;
using System.Runtime.InteropServices;

namespace VariableScope
{
    internal class Program
    {
        static string globalVariable = "전역변수";
        static void Main(string[] args)
        {
            string globalVariable = "지역변수";
            Console.WriteLine(globalVariable);
            Test();
        }
        static void Test() => Console.WriteLine(globalVariable);
    }

    
}
