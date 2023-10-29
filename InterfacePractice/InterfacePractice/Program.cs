using System;

public interface IRepository
{
    void Get();
}

public class Reopository : IRepository
{
    public void Get()
    {
        Console.WriteLine("Get() 메서드를 구현해야 합니다.");
    }
}

namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new Reopository();
            repository.Get();
        }
    }
}
