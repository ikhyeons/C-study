using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParameter
{
    class My
    {
        private string _name;
        private int _age;

        public My(string name, int age) {
            this._name = name;
            this._age = age;
        }
        public void PrintMy()
        {
            Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            My me = new My("성익현", 32);
            me.PrintMy();
        }
    }
}
