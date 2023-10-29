using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "ABC123";

            foreach(var c in str)  Console.WriteLine(c); 
        }
    }
}
