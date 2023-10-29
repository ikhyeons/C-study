using System;

namespace PropertyNote
{
    public class Person
    {
        private int _BirthYear;
        public string Name { get; set; }
        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                {
                    _BirthYear = value;
                }
                else
                {
                    _BirthYear = 0;
                }
            }
        }
        public int Age
        {
            get { return (DateTime.Now.Year - _BirthYear); }
        }
        public Person(string name)
        {
            Name = name;
        }
    }
}
