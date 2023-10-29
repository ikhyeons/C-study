using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            if(DateTime.TryParse("2023-09-22", out dt))
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("날짜 형식으로 변환할 수 없습니다.");
            }



            if(DateTime.TryParse("2023-09-22", out var myDate))
            {
                Console.WriteLine(myDate);
            };
        }
    }
}


