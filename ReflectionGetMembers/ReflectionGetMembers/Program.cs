﻿using System;
using System.Reflection;

namespace ReflectionGetMembers
{
    class Test
    {
        public static void TestMethod() { }
    }

    class ReflectionGetMembers
    {
        static void Main()
        {
            Type t = typeof(Test);
            MemberInfo[] members = t.GetMembers(BindingFlags.Static | BindingFlags.Public);

            foreach(var member in members)
            {
                Console.WriteLine(member.Name);
            }
        }
    }
}
