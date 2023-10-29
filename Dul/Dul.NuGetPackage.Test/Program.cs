using System;
using Dul;

class Program
{
    static void Main()
    {
        Console.WriteLine(Creator.GetName());
        Console.WriteLine(Dul.Math.Abs(-1234));
        Console.WriteLine("안녕하세요.".CutStringUnicode(6));
        Console.WriteLine(DateTimeUtility.ShowTimeOrDate(DateTime.Now));
    }
}