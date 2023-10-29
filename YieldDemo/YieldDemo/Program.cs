using System;
using System.Collections;

class YieldDemo
{
    static IEnumerable GetNumbers()
    {
        yield return 1;
        yield return 2;
        for(int i = 3; i<=5; i++)
        {
            yield return i;
        }
    }

    static void Main()
    {
        foreach(int num in GetNumbers())
        {
            Console.WriteLine($"{num}\t", num);
        }
        Console.WriteLine();
    }
}