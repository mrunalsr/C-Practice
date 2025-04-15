//C# Method Parameters
using System;
namespace std
{
    class Program{
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Employee");
        }
        static void Main(string[] args)
        {
            MyMethod("Mrunal");
            MyMethod("Sakshi");
            MyMethod("Srushti");

        }
    }
}