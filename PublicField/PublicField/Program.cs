using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicField
{

    class Category
    {
        public string CategoryName;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Category book = new Category();
            book.CategoryName = "책";
            Console.WriteLine(book.CategoryName);
        }
    }
}
