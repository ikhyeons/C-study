using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1234;
            string s = "안녕하세요.";
            char c = 'A';
            double d = 3.14;
            object o = new object();

            Console.WriteLine(i.GetType());
            Console.WriteLine(s.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(o.GetType());
        }
    }
}
