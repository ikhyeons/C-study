using System;

namespace FunctionCall
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Hi(); Hi(); Hi();
        }

        static void Hi() { Console.WriteLine("안녕하세요"); }
    }
}
