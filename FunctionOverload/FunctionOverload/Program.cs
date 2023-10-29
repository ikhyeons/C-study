using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi();
            Multi("반갑습니다");
            Multi("하이요", 3);
        }

        static void Multi()
        {
            Console.WriteLine("안녕하세요");
        }

        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}
