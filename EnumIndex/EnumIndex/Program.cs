using System;

namespace EnumIndex
{
    internal class Program
    {
        enum Animal { Rabbit, Dragon, Snake};
        static void Main(string[] args) 
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal;

            string str = animal.ToString();
            Console.WriteLine($"Animal.Dragon : {num}, {str}");

        }
    }
}
