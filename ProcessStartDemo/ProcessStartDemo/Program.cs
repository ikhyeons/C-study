using System.Diagnostics;

namespace DotNet
{
    internal class ProcessStartDemo
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
            Process.Start("Explorer.exe", "https://dotnetkorea.com");
        }
    }
}
