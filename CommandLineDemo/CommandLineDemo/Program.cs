using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(args[0]);
            int second = Convert.ToInt32(args[1]);

            Console.WriteLine(first + second);
        }
    }
}
