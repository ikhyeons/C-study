﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3 };

            int max = numbers.Max();
            Console.WriteLine($"{nameof(numbers)} 컬렉션의 최댓값 : { max}");
        }
    }
}
