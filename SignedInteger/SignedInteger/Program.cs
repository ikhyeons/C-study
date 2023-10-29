using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedInteger
{
    internal class SignedInteger
    {
        static void Main(string[] args)
        {

            byte iBype = 255;
            ushort iUInt16 = 65535;
            uint iUInt32 = 4294967295;
            ulong iUInt64 = 18446744073709551615;

            Console.WriteLine("8비트 sbype : {0}", iBype);
            Console.WriteLine("16비트 sbype : {0}", iUInt16);
            Console.WriteLine("32비트 sbype : {0}", iUInt32);
            Console.WriteLine("64비트 sbype : {0}", iUInt64);
        }
    }
}
