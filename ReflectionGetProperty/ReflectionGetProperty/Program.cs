using System;
using System.Reflection;

namespace ReflectionGetProperty
{
    class Person
    {
        [Obsolete] public string Name { get; set; }
    }

    class ReflectionGetProperty
    {
        static void Main()
        {
            PropertyInfo pi = typeof(Person).GetProperty("Name");

            object[] attributes = pi.GetCustomAttributes(false);
            foreach (object attribute in attributes)
            {
                Console.WriteLine("{0}", attribute.GetType().Name);
            }
        }
    }
}
