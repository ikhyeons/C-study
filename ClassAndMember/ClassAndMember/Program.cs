﻿using System;

public class ClassName
{
    public void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

public class ClassAndMember
{
    public static void Main()
    {
        ClassName member = new ClassName();
        member.MemberName();
    }
}