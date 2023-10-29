using System;

namespace ClaslsToString
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public override string ToString() => $"[Person  클래스 : {this.name}]";
    }

    class ClassToString
    {
        static void Main()
        {
            Person person = new Person("성익현");
            Console.WriteLine(person);
        }
    }
}
