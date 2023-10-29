using System;

namespace FunctionParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage("매개변수");
            ShowMessage("Parameter");
        }

        static void ShowMessage(string message) {
            Console.WriteLine(message);
        }
    }
}
