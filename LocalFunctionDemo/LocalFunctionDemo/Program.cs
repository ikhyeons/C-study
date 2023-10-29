using System;

namespace LocalFunctionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Display(string text) { 
            Console.WriteLine(text);
            }
            Display("로컬함수");
        }
    }
}
