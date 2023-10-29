using System;
using System.Runtime.InteropServices;

namespace IsAn
{
    class Vehicle { }
    class Car : Vehicle { }
    class Airplane : Vehicle { }

    class IsAn
    {
        static void Main()
        {
            Vehicle v = new Vehicle();
            Vehicle car = new Car();
            Vehicle airplane = new Airplane();


            Console.WriteLine($"{v} {car} {airplane}");
        }
    }

}
