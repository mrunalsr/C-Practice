//C# Default Parameters
using System;
namespace std{
    class Program{
        static void MyMethod(string country = "India")
        {
            Console.WriteLine(country);
        }
        static void Main(string[] args)
        {
            MyMethod("Norway");
            MyMethod("Japan");
            MyMethod();
            MyMethod("USA");
        }
    }
}