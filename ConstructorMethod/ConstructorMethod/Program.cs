using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{


    class Student
    {
        public Student()
        {
            Console.WriteLine("Student 개체가 생성됩니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            student = new Student();
        }
    }
}
