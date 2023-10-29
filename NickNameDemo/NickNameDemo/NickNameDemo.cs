using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameDemo
{
    internal class NickNameDemo
    {
        static void Main()
        {
            var nick = new NickName();

            nick["박용준"] = "RedPlus";
            nick["성익현"] = "IK";

            Console.WriteLine($"{nick["성익현"]}, {nick["박용준"]}");
        }
    }
}
