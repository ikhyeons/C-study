using System;
using System.IO;

class FileAndFileInfo
{
    static void Main()
    {
        string file = "C:/Temp/Test.txt";

        if(File.Exists(file))
        {
            Console.WriteLine("{0}", File.GetCreationTime(file));
            File.Copy(file, "C:/Temp/Test2.txt", true);
        }

        FileInfo fi = new FileInfo(file);
        if (fi.Exists)
        {
            Console.WriteLine($"{fi.FullName}");
        }
    }
}