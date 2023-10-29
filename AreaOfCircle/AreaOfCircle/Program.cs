using System;

namespace AreaOfCircle
{
    class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            this._radius = radius;
        }
        public void getArea()
        {
            Console.WriteLine($"이 원의 넓이는 {this._radius * this._radius * Math.PI} 입니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            circle.getArea();
        }
    }
}
