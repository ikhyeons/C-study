using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Hello
    {
        static void Main()
        {
            var hello = new Hello();
            hello.Hi();
            hello.Bye();
        }
    }
}

