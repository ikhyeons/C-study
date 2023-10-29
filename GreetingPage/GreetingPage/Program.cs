using System;
using System.Runtime.CompilerServices;

namespace GreetingPage
{
    internal class Program
    {
        class Greeting
        {
            private string message = "사이트에 오신 것을 환영합니다.";
            public void Say() => Console.WriteLine(this.message);
        }
        static void Main(string[] args)=>(new Greeting()).Say();
        
    }
}
