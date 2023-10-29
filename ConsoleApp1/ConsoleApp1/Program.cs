using System;
using System.Runtime.InteropServices;

namespace Program
{
    internal class MyFirstClass
    {
        static void StaticMethod() => Console.WriteLine("[1] 정적 메서드");
         void InstanceMethod() => Console.WriteLine("[2] 인스턴스 메서드");
        static void Main(string[] args)
        {
            MyFirstClass.StaticMethod();
            MyFirstClass my = new MyFirstClass();
            my.InstanceMethod();
        }
    }
}
