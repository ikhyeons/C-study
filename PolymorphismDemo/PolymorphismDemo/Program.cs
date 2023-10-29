using System;

namespace PolymorphismDemo
{
    public abstract class Animal
    {
        public abstract string Cry();
    }
    public class Dog: Animal
    {
        public override string Cry() => "멍멍멍";
    }

    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }

    public class Trainer
    {
        public void DoCry(Animal animal)
        {
            Console.WriteLine("{0}", animal.Cry());
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Dog()).Cry());
            Console.WriteLine((new Cat()).Cry());
        }
    }
}
