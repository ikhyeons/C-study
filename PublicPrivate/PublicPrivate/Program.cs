using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivate
{
    public class TestClass
    {
        private static string name = "성익현";
        public static string siteNmae = "ikhyeons";

        public static string GetName() { return name; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestClass.siteNmae);
            Console.WriteLine(TestClass.GetName());
        }
    }
}
