﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class CategoryClass
{
    public void Print(int i ) => Console.WriteLine($"카테고리 {i}");
}

internal class Program
{
    static void Main(string[] args)
    {
        CategoryClass[] categories = new CategoryClass[3];

        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        for(int i = 0; i< categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
