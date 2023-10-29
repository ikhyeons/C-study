using System;
using static System.Console;

namespace PatternMatchingWithIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStars(null);
            PrintStars("하나");
            PrintStars(5);
        }

        static void PrintStars(object o) { 
            if (o is null)
            {
                return;
            }
            if(o is string)
            {
                return;
            }
            if (!(o is int number)) {
                return;
            }
            WriteLine(new string('*', number));
        }
    }
}
