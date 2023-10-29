using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte x = 10;
            Console.WriteLine(
                    $"십진수 : {x} => 이진수 : {Convert.ToString(x, 2).PadLeft(8, '0')}"
                );
        }
    }
}
