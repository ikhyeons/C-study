using System;

namespace ArrowDemo
{
    internal class Program
    {
        class Counter
        {
            private int count;
            public int Count { get { return count; } set { count = value;} }
            public void IncreseCount() => Count++;
        }
        static Counter counter;
        static void Main(string[] args)
        {
            counter = new Counter();
            counter.IncreseCount();
            Console.WriteLine($"카운트 : {counter.Count}");
        }
    }
}
