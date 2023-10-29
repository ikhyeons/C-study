using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLineCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자를 입력하세요 : ");
            string input = Console.ReadLine();
            char c = Convert.ToChar(input);
            Console.WriteLine(c);
        }
    }
}
