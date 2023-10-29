using System;
using System.Linq;

namespace ArrayThreeDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,,] data = { { { "C#", "ASP.NET" }, { "Windows Forms", "WPF" } }, { { "Xamarin", "Unity" }, { "UWP", "Azure" } } };

            Console.WriteLine($"0층\n");
            Console.WriteLine($"{data[0, 0, 0],20}  {data[0, 0, 1],20}\n");
            Console.WriteLine($"{data[0, 1, 0],20}  {data[0, 1, 1],20}\n");

            Console.WriteLine($"1층\n");
            Console.WriteLine($"{data[1, 0, 0],20}  {data[1, 0, 1],20}\n");
            Console.WriteLine($"{data[1, 1, 0],20}  {data[1, 1, 1],20}\n");


        }
    }
}
