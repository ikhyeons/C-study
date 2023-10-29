using System;

namespace InheritaneDemo
{
    class Parent
    {
        public void Foo() => Console.WriteLine("부모 클래스의 멤버 호출");
    }

    class Child : Parent {
        public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
    }

   class InheritanceDemo
    {
        static void Main()
        {
            var child = new Child();
            child.Foo();
            child.Bar();
        }
    }
}
