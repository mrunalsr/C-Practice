//C# Return values from methods
using System;
namespace std{
    class Program{
        static int MyMethod(int x)
        {
            return x+5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }
    }
}