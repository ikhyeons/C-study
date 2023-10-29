using System;
using System.Collections;
using System.Collections.Generic;

namespace StackNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("첫 번째");
            stack.Push("두 번째");
            stack.Push("세 번째");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            try
            {
                Console.WriteLine(stack.Pop());
            }catch (Exception ex)
            {
                Console.WriteLine($"예외 내용: {ex.Message}");
            }
        }
    }
}
