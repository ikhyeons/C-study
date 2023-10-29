using System;

namespace GetSumTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 4));
        }

        ///<summary>이 안에 함수의 문서 주석을 달 수 있음.</summary>///
        ///<param name="a">첫 번째 더할 수</param>
        ///<param name="b">두 번째 더할 수</param>
        ///<returns>두 매개변수의 합</returns>
        static int Sum(int a, int b) {
            return a + b;
        }
    }
}
