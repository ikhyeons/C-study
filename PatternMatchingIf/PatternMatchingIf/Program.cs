﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingIf {
    class Shape { }
    class Rectangle : Shape {
        public string Name { get; set; } = "사각형";
    }
    class PatternMatchingIf {
        static void Main() => ShowShape(new Rectangle());

        static void ShowShape(Shape shape) {
            if (shape is Rectangle r) {
                Console.WriteLine(r.Name);
            }
        }
    }
}
