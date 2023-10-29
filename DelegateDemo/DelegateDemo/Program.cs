using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        static void Hi() => Console.WriteLine("안녕하세요");

        delegate void SayDelegate();
        static void Main(string[] args)
        {
            SayDelegate say = Hi;
            say();

            var hi = new SayDelegate(Hi);
            hi();
        }
    }
}
