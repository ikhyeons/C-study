using System;

namespace PropertyNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.Color = "black";
            Car.Type = "세단";
            Console.WriteLine($"차종 : {Car.Type}, 색상 : {Car.Color}");

            Person person = new Person("성익현");
            person.BirthYear = (DateTime.Now.Year - 21);
            Console.WriteLine($"이름 : {person.Name}, 나이 : {person.Age}");
        }
    }
}
