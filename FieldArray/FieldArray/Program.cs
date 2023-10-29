using System;
using System.Collections.Generic;

namespace FieldArray
{
    class Schedule
    {
        private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public void PrintWeekDays()
        {
            foreach(var day in weekDays)
            {
                Console.WriteLine($"{day} \t");
            }
            Console.WriteLine();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.PrintWeekDays();
        }
    }
}
