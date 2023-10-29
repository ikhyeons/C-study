using System;
using System.IO;

class StreamReaderReadToEndDemo
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"C:/Temp/Test.txt");
        Console.WriteLine("{0}", sr.ReadToEnd());

        sr.Close();
        sr.Dispose();
    }
}