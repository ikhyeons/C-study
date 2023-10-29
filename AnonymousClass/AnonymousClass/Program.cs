using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var presenter = new { Name = "성익현", Age = 24, Topic = "C#" };

            Console.WriteLine($"{presenter.Name}, {presenter.Age}, {presenter.Topic}");
        }
    }
}
