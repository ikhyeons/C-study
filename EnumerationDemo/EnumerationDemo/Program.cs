using System;


enum Priority
{
    High,
    Normal,
    Low
}

namespace EnumerationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Priority high = Priority.High;
            Priority normal = Priority.Normal;
            Priority low = Priority.Low;

            Console.WriteLine($"{high}, {normal}, {low}");
        }
    }
}
