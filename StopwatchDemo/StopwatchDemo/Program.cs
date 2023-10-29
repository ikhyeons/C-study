using System;
using System.Diagnostics;
using System.Threading;

namespace StopwatchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            Console.WriteLine("경과시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            Console.WriteLine("경과시간 : {0}초", timer.Elapsed.TotalSeconds);
        }

        static void LongTimeProcess()
        {
            Thread.Sleep(3000);
        }
    }
}
