using System;
using System.Security.Cryptography.X509Certificates;

namespace GetterSetter
{
    internal class Program
    {
        class GetterSetter { 
        public string Name { get;set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get => (DateTime.Now - BirthDate).Days / 365 + 1;
        }
    }

        static void Main(string[] args)
        {
            GetterSetter user = new GetterSetter();
            user.Name = "마이크로 소프트";
            user.BirthDate = new DateTime(1975, 01, 01);

            Console.WriteLine($"{user.Name} 나이 - {user.Age}");
        }
    }

}
