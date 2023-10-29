using System;

namespace ObjectInitializers
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pp = new Person();
            pp.Name = "성익현";
            pp.Age = 25;

            Person pc = new Person("성익현", 25);

            Person pi = new Person()
            {
                Name = "성익현",
                Age = 25
            };
            Console.WriteLine($"{pp.Name}, {pp.Age}");
            Console.WriteLine($"{pc.Name}, {pc.Age}");
            Console.WriteLine($"{pi.Name}, {pi.Age}");
        }

        

    }
}
