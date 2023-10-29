using System;
using System.Text;


namespace CheckDefaultKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intDefault = default(int);
            Console.WriteLine(intDefault);

            bool boolDefault = default(bool);
            Console.WriteLine(boolDefault);

            string strDefault = default(string);
            Console.WriteLine(strDefault);

            StringBuilder sbDefault = default(StringBuilder);
            Console.WriteLine(sbDefault);
        }
    }
}
