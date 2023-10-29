using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log("디버그");
            Log("에러", 4);
        }
        static void Log(string message, byte level = 1)
        {
            Console.WriteLine($"{message}, {level}");
        }
    }
}
