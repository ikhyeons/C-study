using System;

namespace EnumAnimal
{
    internal class Program
    {
        enum Animal { Mouse, Cow, Tiger };
        static void Main(string[] args)
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);

            if(animal == Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }
        }
    }
}
