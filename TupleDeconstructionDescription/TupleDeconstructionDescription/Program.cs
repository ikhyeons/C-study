using System;
using static System.Console;

class TupleDeconstructinDescription
{
    static void Main()
    {
        var (sum, count) = Tally();
        WriteLine($"Sum : {sum}, Count : {count}");

        (int Sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s}, {r.c}");
            return r;
        }
    }
}