using static System.Console;

namespace ConstrutorToDestructor
{

    public class DestructorTest
    {
        public DestructorTest()
        {
            WriteLine("[1] 생성");
        }
        
        public void Run()
        {
            WriteLine("[2] 실행");
        }
        ~DestructorTest()
        {
            WriteLine("[3] 소멸");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DestructorTest test = new DestructorTest();
            test.Run();
        }
    }
}
;