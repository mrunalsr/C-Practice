//C# Multiple Paramateres
using System;
namespace std{
    class Program{
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname +" is "+ age);
        }
        static void Main(string[] args)
        {
            MyMethod("Mrunal",22);
            MyMethod("Sakshi",24);
            MyMethod("Srushti",30);
        }
    }
}