using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string _Name;
        private int _Age;

        static Person() { _Name = "성익현"; }
        public Person() { _Age = 25; }
        public Person(int _Age)
        {
            this._Age = _Age;
        }
        public static void Show()
        {
            Console.WriteLine("이름 : {0}", _Name);
        }

        public void Print()
        {
            Console.WriteLine("나이 : {0}", _Age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person.Show();

            (new Person()).Print();
            (new Person(22)).Print();
        }
    }
}
