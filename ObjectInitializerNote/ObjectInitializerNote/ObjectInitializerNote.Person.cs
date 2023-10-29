using System;

namespace ObjectInitializerNote
{
    public class Person
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value;} }

        public int Age { get; set; }

        public string Type { get; set; } = "사람";
    }
}
