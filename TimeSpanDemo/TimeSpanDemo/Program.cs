using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan dday = Convert.ToDateTime("2023-12-25") - DateTime.Now;
            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");

            TimeSpan times = DateTime.Now - Convert.ToDateTime("1999-11-23");
            Console.WriteLine($"내가 지금까지 며칠 살아왔는지? {(int)times.TotalDays}");
        }
    }
}
