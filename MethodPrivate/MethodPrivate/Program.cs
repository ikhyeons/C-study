using System;

namespace MethodPrivate
{
    class Dog
    {
        public void Eat()
        {
            Console.WriteLine("[1] 밥을 먹는다.");
            this.Digest();
        }

        private void Digest()
        {
            Console.WriteLine("[2] 소화를 시킨다.");
        }
    }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
        }
    }
}
