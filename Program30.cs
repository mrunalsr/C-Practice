//C# Class Memebers
using System;
using System.Security.Cryptography;
namespace std{
    class Car{
        string name = "Mrunal";
        int age = 21;
        public void full()
        {
            Console.WriteLine($"Hello from {name}");
        }
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            obj.full();
        }
    }
}