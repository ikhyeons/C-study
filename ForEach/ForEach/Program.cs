using System;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC123";

            foreach(char c in str) {
                Console.WriteLine(c);
            }
        }
    }
}
