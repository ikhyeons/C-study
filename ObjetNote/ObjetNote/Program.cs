using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjetNote
{
    public class Counter
    {
        public void GetTodayVisitCount()
        {
            Console.WriteLine("오늘 1234명이 접속했습니다.");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }
}
