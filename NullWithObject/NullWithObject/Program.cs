﻿using System;
using System.Collections.Generic;

namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    class Address
    {
        public string Street { get; set; } 
    }

    class NullWithObject { 
        static void Main()
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null };
            ProcessPeople(people);

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach(var person in peopleArray)
                {
                    Console.WriteLine($"{person?.Name ?? "아무개"}은(는)" + $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");
                }
            }

            var otherPeople = null as Person[];

            Console.WriteLine($"첫 번째 사람 : {otherPeople?[0].Name ?? "없음"}");
        }
    }
}
