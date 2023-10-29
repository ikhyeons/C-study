using System;
using System.Collections.Generic;
using System.Linq;

namespace CountFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln=> bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }
    }
}
