//C# Inheritance
using System;
namespace std{
    class Health{
        public string name = "Mrunal";
        public void Drink()
        {
            Console.WriteLine("Drink 5Li of water everyday");
        }
    }
    class Person : Health{
        public string level = "3lit";

    }
    class Program{
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Drink();
            Console.WriteLine($"Hii My name is {obj.name} and everyday I drink {obj.level} of water");
            
        }
    }
}