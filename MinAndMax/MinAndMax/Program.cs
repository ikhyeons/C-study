﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MinAndMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int min= arr.Min();
            int max = arr.Max();
            Console.WriteLine($"최솟값 : {min} 최댓값 : {max}");
        }
    }
}
