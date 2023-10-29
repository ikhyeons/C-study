using System;

namespace As
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = 1234;
            string s = x as string;
            Console.WriteLine(s == null ? "null" : s);
        }
    }
}
