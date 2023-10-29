using System;

struct Point
{
    public int X;
    public int Y;
}
namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.X = 100;
            point.Y = 200;
            Console.WriteLine($"X : {point.X}, Y : {point.Y}");
        }
    }
}
