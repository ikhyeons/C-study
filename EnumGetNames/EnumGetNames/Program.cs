﻿using System;

namespace EnumGetNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type cc = typeof(ConsoleColor);
            string[] colors = Enum.GetNames(cc);

            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}
