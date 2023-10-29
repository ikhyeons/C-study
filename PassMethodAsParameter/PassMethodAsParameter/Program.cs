using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PassMethodAsParameter
{
    static int StringLength(string data) => data.Length;

    static void StringLengthPrint(Func<string, int> stringLength, string message)
    => Console.WriteLine($"메시지의 크기는 {stringLength(message)}입니다.");

    static void Main() => StringLengthPrint(StringLength, "안녕하세요.");
}