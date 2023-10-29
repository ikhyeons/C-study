using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(2, 2));
        }

       static int MyPower(int num, int cnt) { 
            if(cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }

    }
}
