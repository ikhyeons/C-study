using System;

namespace NameOfOperator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("NameToString");
            Console.WriteLine(nameof(NameToString));
        }

        static void NameToString() { }
    }
}
