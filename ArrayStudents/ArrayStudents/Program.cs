using System;

namespace ArrayStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[3];

            students[0] = Convert.ToInt32(Console.ReadLine());
            students[1] = Convert.ToInt32(Console.ReadLine());
            students[2] = Convert.ToInt32(Console.ReadLine());

            int total = students[0] + students[1] + students[2];
            Console.WriteLine($"총점 : {total}");
        }
    }
}
