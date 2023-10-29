using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class String_Interpolation
    {
        static void Main(string[] args)
        {
            string message = "String Interpolation";
            Console.WriteLine("Message : {0}", message);
            Console.WriteLine("Message : " + message);
            Console.WriteLine($"Message : {message}");


            string name = "C#";
            string version = "8.0";
            Console.WriteLine("{0} {1}", name, version);
            string result = String.Format("{0} {1}", name, version);
            Console.WriteLine(result);
            Console.WriteLine($"{name} {version}");
        }
    }
}
