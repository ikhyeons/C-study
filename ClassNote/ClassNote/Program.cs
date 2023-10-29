using System;

namespace ClassNote
{
    internal class Program
    {
        static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메서드");
        }
        static void Main(string[] args)
        {
            Run();
            Program.Run();
        }
    }
}
