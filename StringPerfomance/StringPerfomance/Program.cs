using System;

namespace StringPerfomance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            string msg = "";
            for (int i = 0; i < 10000; i++) {
                msg += "안녕하세요";
            }

            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);
        }
    }
}
