//C# Multiple objects of one class
using System;
namespace std{
    class Car{
        string name = "Mrunal";
        string lname = "Raksale";
        string mname = "jyoti";
        static void Main(string[] args){
            Car obj1 = new Car();
            Car obj2 = new Car();

            Console.WriteLine(obj1.name);
            Console.WriteLine(obj2.lname);
            Console.WriteLine(obj1.mname);


        }
    }
}