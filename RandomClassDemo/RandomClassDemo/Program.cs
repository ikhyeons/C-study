using System;
using System.Linq;

namespace RandomClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[6];
            Random ran = new Random();
            for (int i = 0; i < 6; i++)
            {
                int temp = ran.Next(45) + 1;
                if (Array.Exists(numList, x => x == temp))
                {
                    Console.WriteLine($"{temp}가 중복 발생되어 다시 실행합니다.");
                    i--;
                }
                else {
                    numList[i] = temp;
                }
            }

            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
