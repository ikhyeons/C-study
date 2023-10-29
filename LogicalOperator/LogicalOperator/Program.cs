using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 3;
            var j = 5;
            var r = false;

            r = (i == 3) && (j != 3);
            Console.WriteLine(r);

            r = (i != 3) || (j == 3);
            Console.WriteLine(r);

            r = (i >= 5);
            Console.WriteLine("{0}", !r);

            Console.WriteLine(false && true);
            Console.WriteLine((1 == 1) || (1 != 1));
            Console.WriteLine(!(1 == 1));
        }
    }
}
