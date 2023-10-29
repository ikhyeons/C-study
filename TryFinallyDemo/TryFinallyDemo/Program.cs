using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFinallyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] 시작");

            try
            {
                Console.WriteLine("[2] 실행");
                throw new Exception();
            }
            finally { Console.WriteLine("[3] 종료"); }
        }
    }
}
