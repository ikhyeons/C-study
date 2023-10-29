using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            this.Name = name;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car("자동차");
            Console.WriteLine(car.Name);
            Console.WriteLine((new Car("").Name));
        }
    }
}
