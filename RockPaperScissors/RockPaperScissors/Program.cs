﻿using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iRandom = 0;
            int iSelection = 0;
            string[] choice = { "가위", "바위", "보" };

            iRandom = (new Random()).Next(1, 4); // 컴퓨터의 랜덤 값 지정

            Console.WriteLine("1(가위), 2(바위), 3(보) 입력 : _\b");
            iSelection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n 사용자 : {0}", choice[iSelection-1]);
            Console.WriteLine("\n 컴퓨터 : {0}\n", choice[iRandom - 1]);

            if(iSelection == iRandom) Console.WriteLine("비김");
            else
            {
                switch(iSelection)
                {
                    case 1:
                        Console.WriteLine((iRandom == 3) ? "승" : "패"); break;
                    case 2:
                        Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
                    case 3:
                        Console.WriteLine((iRandom == 2) ? "승" : "패"); break;
                }
            }
        }
    }
}
