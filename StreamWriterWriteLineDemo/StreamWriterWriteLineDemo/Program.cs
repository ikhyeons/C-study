using System;
using System.IO;

class StreamWriterWriteLineDemo
{
    static void Main()
    {
        string data = "안녕하세요. \r\n반갑습니다." + Environment.NewLine + "또 만나요.";

        StreamWriter sw = new StreamWriter("C:/Temp/Test.txt");

        sw.WriteLine(data);

        sw.Close();

        sw.Dispose();
    }
}