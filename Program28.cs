//C# Class and Objects
using System;
namespace std{
    class Car{
        string name = "Mrunal";
        int age = 23;
        static void Main(string[] args)
        {
            Car myobj = new Car();
            Console.WriteLine(myobj.name);
            Console.WriteLine(myobj.age);
        }
    }
}