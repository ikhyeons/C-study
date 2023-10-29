using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringMethod
{

    class My { }

    class Your
    {
        public override string ToString()
        {
            return "새로운 반환 문자열 지정";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            My my = new My();

            Console.WriteLine(my.ToString());

            Your your = new Your();
            Console.WriteLine(your.ToString());
        }
    }
}
