using System;

namespace ObjectInitializerNote
{
    internal class ObjectInitializerNote
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "성익현";
            p1.Age = 25;
            Console.WriteLine($"이름 : {p1.Name}, 나이 : {p1.Age}, 타입 : {p1.Type}");

            Person p2 = new Person() { Name = "성익현2", Age = 24 };
            Console.WriteLine($"이름 : {p2.Name}, 나이 : {p2.Age}, 타입 : {p2.Type}");
        }
    }
}
