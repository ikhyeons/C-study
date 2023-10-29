using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SampleAttribute : Attribute { public SampleAttribute() => Console.WriteLine("사용자 지정 특성 사용 됨."); }

[Sample]
public class CustomAttributeTest { }

class AttributePractice
{
    static void Main()
    {
        Attribute.GetCustomAttributes(typeof(CustomAttributeTest));
    }
}