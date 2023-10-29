using System;

namespace TryCatchFinallyDeno1
{
    internal class TryCatchFinallyDemo1
    {
        static void Main() { 
            int x = 5;
            int y = 3;
            int result = 0;

            result = x / y;

            Console.WriteLine($"{x} / {y} = {result}");
        }
    }
}
