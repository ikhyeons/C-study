using System;


public class MyClass
{
    public void Test() => Console.WriteLine("MyClass의 Test() 메서드가 실행됩니다.");
}

class TypeAndActivator
{
    static void Main()
    {
        Type type = Type.GetType("MyClass");
        Console.WriteLine(type);
        dynamic objType = Activator.CreateInstance(type);

        objType.Test();
    }
}

