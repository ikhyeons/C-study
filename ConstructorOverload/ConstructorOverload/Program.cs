using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverload
{

    class ConstructorLog
    {
        public ConstructorLog()
        {
            Console.WriteLine("기본 생성자 실행");
        }

        public ConstructorLog(string message)
        {
            Console.WriteLine("오버로드 된 생성자 실행 : " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorLog log = new ConstructorLog();
            ConstructorLog log2 = new ConstructorLog("안녕하세요");
        }
    }
}
