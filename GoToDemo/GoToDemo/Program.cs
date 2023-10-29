using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작");
            Start:
            Console.WriteLine("1, 2, 3 중 하나 입력 : _\b");
            int chapter = Convert.ToInt32(Console.ReadLine());

            if (chapter == 1) goto Chapter1;
            else if (chapter == 2) goto Chapter2;
            else goto End; ;

        Chapter1:
            Console.WriteLine("1장입니다.");
        Chapter2:
            Console.WriteLine("2장입니다.");
            goto Start;
        End:
            Console.WriteLine("종료.");
        }
    }
}
