using System;


namespace ReadLineRealNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("실수를 입력하세요 : ");
            string input = Console.ReadLine();
            double PI = Convert.ToDouble(input);
            Console.WriteLine(PI);
        }
    }
}
