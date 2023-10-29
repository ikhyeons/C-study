using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DelegateNote
{
    delegate void SayPointer();

    static void Hello() => Console.WriteLine("Hello Delegate");

    static void Main()
    {
        SayPointer sayPointer = new SayPointer(Hello);

        sayPointer = Hello;
        sayPointer();

        sayPointer.Invoke();
    }
}