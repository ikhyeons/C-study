﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{

    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("생성자가 호출되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorDemo constructorDemo = new ConstructorDemo();
        }
    }
}
