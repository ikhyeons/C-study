using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 1, 4, 5 };
            IEnumerable<int> methodSyntax =
                numbers.Where(n=> n%2 == 1).OrderBy(n => n);

            foreach (var n in methodSyntax) {
                Console.WriteLine(n);
            }


            IEnumerable<int> querySyntax = 
                from num in numbers
                where num %2 == 1
                orderby num
                select num;

            foreach (var n in querySyntax)
            {
                Console.WriteLine(n);
            }
        }
    }
}
