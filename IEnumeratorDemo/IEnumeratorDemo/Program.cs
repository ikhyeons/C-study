using System;
using System.Collections;


namespace IEnumeratorDemo
{
    class IEnumeratorDemo
    {
        static void Main()
        {
            string[] names = { "닷넷 코리아", "비주얼 아카데미" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            IEnumerator list = names.GetEnumerator();
            while(list.MoveNext())
            {
                Console.WriteLine(list.Current);
            }
        }
    }
}
